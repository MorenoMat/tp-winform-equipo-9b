using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using dominio;
using negocio;

namespace winform_app
{
    public partial class nuevoArticulo : Form
    {
        public nuevoArticulo()
        {
            InitializeComponent();
        }

        private void nuevoArticulo_Load(object sender, EventArgs e)
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
            Articulo articulo = new Articulo();
            articulo.codigo = textBox1.Text;
            articulo.nombre = textBox2.Text;
            articulo.precio = decimal.Parse(textBox3.Text);
            articulo.descripcion = textBox4.Text;
            articulo.marca = comboBox1.SelectedItem as Marca;
            articulo.categoria = comboBox2.SelectedItem as Categoria;

            ArticuloNegocio negocio = new ArticuloNegocio();
            int nuevoId = negocio.agregar(articulo);

            Imagen imagenSeleccionada = comboBox3.SelectedItem as Imagen;
            if (imagenSeleccionada != null)
            {
                ImagenNegocio imagenNegocio = new ImagenNegocio();
                imagenNegocio.actualizarArticulo(imagenSeleccionada.id, nuevoId);
            }

            MessageBox.Show("Artículo agregado correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
