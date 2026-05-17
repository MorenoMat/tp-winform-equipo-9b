using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using dominio;
using negocio;

namespace winform_app
{
    public partial class editarArticulo : Form
    {
        private Articulo articulo;

        public editarArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        private void editarArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            List<Marca> marcas = marcaNegocio.listarTodos();
            comboBox1.DataSource = marcas;
            comboBox1.DisplayMember = "descripcion";
            comboBox1.ValueMember = "id";

            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            List<Categoria> categorias = categoriaNegocio.listarTodos();
            comboBox2.DataSource = categorias;
            comboBox2.DisplayMember = "descripcion";
            comboBox2.ValueMember = "id";

            ImagenNegocio imagenNegocio = new ImagenNegocio();
            List<Imagen> imagenes = imagenNegocio.listarTodos();
            comboBox3.DataSource = imagenes;
            comboBox3.DisplayMember = "imagenUrl";
            comboBox3.ValueMember = "id";

            textBox1.Text = articulo.codigo;
            textBox2.Text = articulo.nombre;
            textBox3.Text = articulo.precio.ToString();
            textBox4.Text = articulo.descripcion;
            comboBox1.SelectedValue = articulo.marca.id;
            comboBox2.SelectedValue = articulo.categoria.id;

            List<Imagen> imagenesArticulo = imagenNegocio.buscarPorArticulo(articulo.id);
            if (imagenesArticulo.Count > 0)
            {
                comboBox3.SelectedValue = imagenesArticulo[0].id;
                cargarImagen(imagenesArticulo[0].imagenUrl);
            }
        }

        private void cargarImagen(string url)
        {
            try
            {
                pictureBox1.Load(url);
            }
            catch (Exception)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.Clear(Color.LightGray);
                    g.DrawString("Imagen no encontrada", new Font("Arial", 10), Brushes.Gray, new PointF(10, pictureBox1.Height / 2 - 10));
                }
                pictureBox1.Image = bmp;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Imagen imagen = comboBox3.SelectedItem as Imagen;
            if (imagen == null) return;
            cargarImagen(imagen.imagenUrl);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(textBox3.Text, @"^\d*\.?\d*$"))
            {
                textBox3.Text = textBox3.Text.Remove(textBox3.Text.Length - 1);
                textBox3.SelectionStart = textBox3.Text.Length;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            articulo.codigo = textBox1.Text;
            articulo.nombre = textBox2.Text;
            articulo.precio = decimal.Parse(textBox3.Text);
            articulo.descripcion = textBox4.Text;
            articulo.marca = comboBox1.SelectedItem as Marca;
            articulo.categoria = comboBox2.SelectedItem as Categoria;

            ArticuloNegocio negocio = new ArticuloNegocio();
            negocio.actualizar(articulo);

            Imagen imagenSeleccionada = comboBox3.SelectedItem as Imagen;
            if (imagenSeleccionada != null)
            {
                ImagenNegocio imagenNegocio = new ImagenNegocio();
                imagenNegocio.actualizarArticulo(imagenSeleccionada.id, articulo.id);
            }

            MessageBox.Show("Artículo actualizado correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
