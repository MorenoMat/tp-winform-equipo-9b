using System;
using System.Reflection.Emit;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using winform_app.baseDeDatos;
using winform_app.Controllers;
using winform_app.Models;

namespace winform_app.Forms.Marca
{
    public partial class MarcaNewForm : Form
    {
        private readonly MarcaController _marcaController = new MarcaController();
        
        private Models.Marca _marca;
        public MarcaNewForm()
        {
            InitializeComponent();
            _marca = new Models.Marca();
            Text = "Nueva marca";
            //CargarCombos();
            //SuscribirEventos();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void _lblMarcaNueva_Click(object sender, EventArgs e)
        {

        }

        private void MarcaNewForm_Load(object sender, EventArgs e)
        {
            _dgvMarcas.AutoGenerateColumns = false; //  para que no cree las otras


            _dgvMarcas.Columns["Marcas"].DataPropertyName = "Descripcion";

            _dgvMarcas.DataSource = _marcaController.GetAll();
        }

        private void _dgvMarcas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
        }

        private void _dgvMarcas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private bool Validar()
        {
            string marca = txtBNuevaMarca.Text?.Trim();
            if (string.IsNullOrWhiteSpace(marca))
            {
                MessageBox.Show("Ingrese una marca válida.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (_marcaController.ExisteConNombre(txtBNuevaMarca.Text.Trim(), _marca.Id))
            {
                MessageBox.Show("Ya existe un artículo con ese nombre.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBNuevaMarca.Focus();
                return false;
            }
            _marcaController.Add(marca);
            return true;
        }
    


private void _btnGuardarMarcaNueva_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validar())
                {
                    return;
                }
                // Refrescar la grilla y limpiar el textbox
                _dgvMarcas.DataSource = _marcaController.GetAll();
                txtBNuevaMarca.Text = string.Empty;
                MessageBox.Show("Marca guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void _btnCancelarMarcaNueva_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
