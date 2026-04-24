using System;
using System.Reflection.Emit;
using System.Windows.Forms;
using winform_app.Controllers;
using winform_app.Forms.Articulo;
using winform_app.Models;

namespace winform_app.Forms
{
    public partial class MainForm : Form //herencia 
    {   //ReadOnly
        private readonly ArticuloController _articuloController = new ArticuloController();
        private readonly MarcaController _marcaController = new MarcaController();
        private readonly CategoriaController _categoriaController = new CategoriaController();
        
        public MainForm()
        {
            InitializeComponent();
            Load += MainForm_Load; // antes de q termine de cargar la ventana  inicia esto 
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CargarFiltros(); //funciones
            CargarArticulos();
        }

        private void CargarFiltros()
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

        private void CargarArticulos()
        {
            try
            {
                var lista = _articuloController.GetAll();
                _dgvArticulos.DataSource = lista;
                _lblStatus.Text = $"{lista.Count} artículo(s) encontrado(s)";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar artículos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Models.Articulo ArticuloSeleccionado()
        {
            if (_dgvArticulos.CurrentRow == null) return null; //devuelve el articulo si lo seleccionado no es nulo
            return _dgvArticulos.CurrentRow.DataBoundItem as Models.Articulo;  //databound devuelve el objeto entero
        }

        // Selección en grilla → mostrar detalle
        private void DgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            var art = ArticuloSeleccionado();
            if (art == null) return;
            // carga el detalle del articulo SELECCIONADO
            _lblDetalleCodigoVal.Text = art.Codigo;
            _lblDetalleNombreVal.Text = art.Nombre;
            _lblDetallePrecioVal.Text = art.Precio.ToString("C");
            _lblDetalleMarcaVal.Text = art.MarcaNombre;
            _lblDetalleCategoriaVal.Text = art.CategoriaNombre;
            _lblDetalleDescVal.Text = art.Descripcion;
        }

        // Botón Nuevo
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            using (var form = new ArticuloEditForm())
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                    CargarArticulos();
            }
        }

        // Botón Editar
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            var art = ArticuloSeleccionado();
            if (art == null)
            {
                MessageBox.Show("Seleccioná un artículo para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (var form = new ArticuloEditForm(art))
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                    CargarArticulos();
            }
        }

        // Botón Eliminar
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            var art = ArticuloSeleccionado();
            if (art == null)
            {
                MessageBox.Show("Seleccioná un artículo para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (var form = new ArticuloDeleteForm(art))
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                    CargarArticulos();
            }
        }

        // Botón Buscar
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            // TODO: implementar filtrado por texto, marca y categoría
            // este es el boton

            // guardo lo colocado en la ventana
            string nombre = _txtBuscar.Text;
            string marca = _cmbMarca.Text; //cmb xq el name de el casillero marca es _cmbMarca
            string categoria = _cmbCategoria.Text;

            _dgvArticulos.DataSource = _articuloController.filtrar(nombre, marca, categoria);



            // Ocultamos las columnas que no queremos ver
            _dgvArticulos.Columns["Id"].Visible = false;
            _dgvArticulos.Columns["Marca"].Visible = false;
            _dgvArticulos.Columns["Categoria"].Visible = false;
            _dgvArticulos.Columns["MarcaId"].Visible = false;
            _dgvArticulos.Columns["CategoriaId"].Visible = false;

        }

        // Botón Limpiar
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            _txtBuscar.Clear();
            _cmbMarca.SelectedIndex = -1;
            _cmbCategoria.SelectedIndex = -1;
            CargarArticulos();
        }

        private void _txtBuscarNombre_TextChanged(object sender, EventArgs e)
        {
            //aca para con el tema del nombre 



        }

        private void _lblBuscarNombre_Click(object sender, EventArgs e)
        {// label
        }

        private void _cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            // desplegar lista marca 
        }

        private void _cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            //desplegar lista categoria
        }

        private void _lblMarca_Click(object sender, EventArgs e)
        { //label
        }

        private void _lblCategoria_Click(object sender, EventArgs e)
        { //label
        }
    }
}

