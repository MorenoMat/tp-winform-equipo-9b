using System;
using System.Drawing;
using System.Windows.Forms;
using winform_app.Controllers;
using winform_app.Models;

namespace winform_app.Forms
{
    public class MainForm : Form
    {
        private readonly Button _btnTestConn;
        private readonly ArticuloController _articuloController = new ArticuloController();

        public MainForm()
        {
            Text = "Gestión de Artículos";
            Width = 800;
            Height = 600;

            _btnTestConn = new Button { Text = "Probar conexión", Left = 10, Top = 10, Width = 140 };
            _btnTestConn.Click += BtnTestConn_Click;

            Controls.Add(_btnTestConn);
        }

        private void BtnTestConn_Click(object sender, EventArgs e)
        {
            // Probar conexión abriendo y cerrando una lectura simple
            try
            {
                var articulo = _articuloController.GetById(1);
                if (articulo != null)
                {
                    var marca = articulo.Marca?.Descripcion ?? "(sin marca)";
                    var categoria = articulo.Categoria?.Descripcion ?? "(sin categoría)";
                    var msg = $"Id: {articulo.Id}\nCodigo: {articulo.Codigo}\nNombre: {articulo.Nombre}\nPrecio: {articulo.Precio:C}\nDescripcion: {articulo.Descripcion}\nMarca: {marca}\nCategoria: {categoria}";
                    MessageBox.Show(msg, "Artículo ID 1", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se encontró el artículo con ID = 1 o no se pudo conectar.", "Conexión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener el artículo: {ex.Message}", "Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(793, 447);
            this.Name = "MainForm";
            this.ResumeLayout(false);

        }
    }
}
