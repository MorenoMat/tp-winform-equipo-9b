using System;
using System.Windows.Forms;
using winform_app.Controllers;

namespace winform_app.Forms.Articulo
{
    public partial class ArticuloDeleteForm : Form
    {
        private readonly ArticuloController _controller = new ArticuloController();
        private readonly Models.Articulo _articulo;

        public ArticuloDeleteForm(Models.Articulo articulo)
        {
            InitializeComponent();
            _articulo = articulo;
            _lblNombreArticulo.Text = $"{articulo.Codigo} — {articulo.Nombre}";
            _btnConfirmar.Click += BtnConfirmar_Click;
            _btnCancelar.Click += BtnCancelar_Click;
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                _controller.Delete(_articulo.Id);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
