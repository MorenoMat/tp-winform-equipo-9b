using System;
using System.Windows.Forms;
using winform_app.Controllers;
using winform_app.Models;

namespace winform_app.Forms.Categoria
{
    public partial class CategoriaNewForm: Form
    {
    private readonly CategoriaController _categoriaController = new CategoriaController();
        private Models.Categoria _categoria;
        public CategoriaNewForm()
        {
            InitializeComponent();
        }

        private void Categoriasexistentes_Click(object sender, EventArgs e)
        {

        }

        private void txtBNuevaCategoria_TextChanged(object sender, EventArgs e)
        {

        }
        private void CategoriaNewForm_Load(object sender, EventArgs e)
        {
            _dgvCategorias.AutoGenerateColumns = false; //  para que no cree las otras


            _dgvCategorias.Columns["Categorias"].DataPropertyName = "Descripcion";
            // la columna la agregue visualmente en winforms
            _dgvCategorias.DataSource = _categoriaController.GetAll();
        }

        private void _dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void _lblCategoriaNueva_Click(object sender, EventArgs e)
        {

        }
        private bool Validar()
        {
            string categoria = txtBNuevaCategoria.Text?.Trim();
            if (string.IsNullOrWhiteSpace(categoria))
            {
                MessageBox.Show("Ingrese una categoría válida.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (_categoriaController.ExisteConNombre(txtBNuevaCategoria.Text.Trim()))
            {
                MessageBox.Show("Ya existe una categoría con ese nombre.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBNuevaCategoria.Focus();
                return false;
            }
            _categoriaController.Add(categoria);
            return true;
        }
        private void _btnGuardarCategoriaNueva_Click(object sender, EventArgs e)
        {
            txtBNuevaCategoria.Text = txtBNuevaCategoria.Text?.Trim();

            try
            {
                if (!Validar())
                {
                    MessageBox.Show("Categoría invalida.", "Fracaso", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                    return;
                }

                // Refrescar la grilla y limpiar el textbox
                _dgvCategorias.DataSource = _categoriaController.GetAll();
                                txtBNuevaCategoria.Clear();
              

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

     



        }

        private void _btnCancelarCategoriaNueva_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();

        }


    }
}
