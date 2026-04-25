using System;
using System.Windows.Forms;
using winform_app.Controllers;
using winform_app.Models;

namespace winform_app.Forms.Articulo
{
    public partial class ArticuloEditForm : Form
    {
        private readonly ArticuloController _articuloController = new ArticuloController();
        private readonly MarcaController _marcaController = new MarcaController();
        private readonly CategoriaController _categoriaController = new CategoriaController();
        private Models.Articulo _articulo;

        // Modo alta: sin parámetro
        public ArticuloEditForm()
        {
            InitializeComponent();
            _articulo = new Models.Articulo();
            Text = "Nuevo artículo";
            CargarCombos();
            SuscribirEventos();
        }


        // Modo edición: con artículo existente
        public ArticuloEditForm(Models.Articulo articulo)
        {
            InitializeComponent();
            _articulo = articulo;
            Text = "Editar artículo";
            CargarCombos();
            CargarDatos();
            SuscribirEventos();
        }

        private void CargarCombos()
        {
            _cmbMarca.DataSource = _marcaController.GetAll();
            _cmbMarca.DisplayMember = "Descripcion";
            _cmbMarca.ValueMember = "Id";
            _cmbMarca.SelectedIndex = -1;

            _cmbCategoria.DataSource = _categoriaController.GetAll();
            _cmbCategoria.DisplayMember = "Descripcion";
            _cmbCategoria.ValueMember = "Id";
            _cmbCategoria.SelectedIndex = -1;
        }

        private void CargarDatos()
        {
            _txtCodigo.Text = _articulo.Codigo;
            _txtNombre.Text = _articulo.Nombre;
            _txtPrecio.Text = _articulo.Precio.ToString();
            _txtDescripcion.Text = _articulo.Descripcion;
            _cmbMarca.SelectedValue = _articulo.MarcaId;
            _cmbCategoria.SelectedValue = _articulo.CategoriaId;
        }

        private void SuscribirEventos()
        {
            _btnGuardar.Click += BtnGuardar_Click;
            _btnCancelar.Click += BtnCancelar_Click;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            



            try
            {
                if (!Validar()) return; //si devuelve falso retorna
                _articulo.Codigo = _txtCodigo.Text.Trim();
                _articulo.Nombre = _txtNombre.Text.Trim(); // trimquita espacios en blanco 
                _articulo.Precio = decimal.Parse(_txtPrecio.Text.Trim());
                _articulo.Descripcion = _txtDescripcion.Text.Trim();
                _articulo.MarcaId = (int)_cmbMarca.SelectedValue;
                _articulo.CategoriaId = (int)_cmbCategoria.SelectedValue;



                if (_articulo.Id == 0)
                        _articuloController.Add(_articulo);
                    else
                        _articuloController.Update(_articulo);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);  
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private bool Validar()
        {
            if (string.IsNullOrWhiteSpace(_txtCodigo.Text))
            {
                MessageBox.Show("El código es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _txtCodigo.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(_txtNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _txtNombre.Focus();
                return false;
            }
            if (!decimal.TryParse(_txtPrecio.Text, out _))
            {
                MessageBox.Show("El precio debe ser un número válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _txtPrecio.Focus();
                return false;
            }
            if (_cmbMarca.SelectedValue == null)
            {
                MessageBox.Show("Seleccioná una marca.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (_cmbCategoria.SelectedValue == null)
            {
                MessageBox.Show("Seleccioná una categoría.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
