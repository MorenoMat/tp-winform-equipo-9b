using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using dominio;
using negocio;

namespace winform_app
{
    public partial class nuevaImagen : Form
    {
        public nuevaImagen()
        {
            InitializeComponent();
        }

        private void nuevaImagen_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            ImagenNegocio negocio = new ImagenNegocio();
            List<Imagen> lista = negocio.listarTodos();

            dgvImagenes.DataSource = null;
            dgvImagenes.DataSource = lista;

            dgvImagenes.Columns["id"].Visible = false;
            dgvImagenes.Columns["idArticulo"].HeaderText = "ID Artículo";
            dgvImagenes.Columns["imagenUrl"].HeaderText = "URL";
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

        private void dgvImagenes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvImagenes.CurrentRow == null) return;
            Imagen imagen = dgvImagenes.CurrentRow.DataBoundItem as Imagen;
            if (imagen == null) return;
            cargarImagen(imagen.imagenUrl);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Imagen imagen = new Imagen();
            imagen.imagenUrl = textBox1.Text;

            ImagenNegocio negocio = new ImagenNegocio();
            negocio.agregar(imagen);

            textBox1.Text = string.Empty;
            cargar();

            MessageBox.Show("Imagen agregada correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
