using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Reflection.Emit;
using System.Threading;
using System.Threading.Tasks;
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
        private readonly ImagenController _imagenController = new ImagenController();
        private static readonly HttpClient _httpClient = new HttpClient();
        private CancellationTokenSource _imagenCts;
        
        public MainForm()
        {
            InitializeComponent();
            Load += MainForm_Load; // antes de q termine de cargar la ventana  inicia esto 
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CargarFiltros();
            CargarArticulos();
            CargarComboArticulosImagenes();
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
        private async void DgvArticulos_SelectionChanged(object sender, EventArgs e)
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

            await CargarImagenAsync(art.Id);
        }

        private async Task CargarImagenAsync(int idArticulo)
        {
            // Cancelar descarga anterior si sigue en curso
            _imagenCts?.Cancel();
            _imagenCts?.Dispose();
            _imagenCts = new CancellationTokenSource();
            var token = _imagenCts.Token;

            _picImagen.Image = null;
            var imagenes = _imagenController.GetByArticuloId(idArticulo);
            if (imagenes == null || imagenes.Count == 0) return;

            try
            {
                _httpClient.DefaultRequestHeaders.UserAgent.TryParseAdd("Mozilla/5.0");
                var data = await _httpClient.GetByteArrayAsync(imagenes[0].ImagenUrl);

                // Si se cambió la selección mientras descargaba, descartar
                if (token.IsCancellationRequested) return;

                using (var ms = new MemoryStream(data))
                {
                    _picImagen.Image = Image.FromStream(ms);
                }
            }
            catch
            {
                if (!token.IsCancellationRequested)
                    _picImagen.Image = null;
            }
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

        // ── Tab Imágenes ────────────────────────────────────────────

        private void CargarComboArticulosImagenes()
        {
            _cmbSelArticulo.DataSource = _articuloController.GetAll();
            _cmbSelArticulo.DisplayMember = "Nombre";
            _cmbSelArticulo.ValueMember = "Id";
            _cmbSelArticulo.SelectedIndex = -1;
        }

        private void CargarImagenesDeArticulo()
        {
            if (_cmbSelArticulo.SelectedItem == null)
            {
                _dgvImagenes.DataSource = null;
                return;
            }
            var art = (Models.Articulo)_cmbSelArticulo.SelectedItem;
            var lista = _imagenController.GetByArticuloId(art.Id);
            _dgvImagenes.DataSource = lista;

            if (_dgvImagenes.Columns.Contains("Articulo"))
                _dgvImagenes.Columns["Articulo"].Visible = false;
            if (_dgvImagenes.Columns.Contains("IdArticulo"))
                _dgvImagenes.Columns["IdArticulo"].Visible = false;
            if (_dgvImagenes.Columns.Contains("Id"))
                _dgvImagenes.Columns["Id"].Visible = false;

            _picPreviewUrl.Image = null;
        }

        private void CmbSelArticulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarImagenesDeArticulo();
        }

        private async void DgvImagenes_SelectionChanged(object sender, EventArgs e)
        {
            if (_dgvImagenes.CurrentRow?.DataBoundItem is Models.Imagen img)
                await CargarPreviewAsync(img.ImagenUrl);
            else
                _picPreviewUrl.Image = null;
        }

        private async Task CargarPreviewAsync(string url)
        {
            _picPreviewUrl.Image = null;
            _picPreviewUrl.Refresh();
            try
            {
                var data = await Task.Run(() =>
                {
                    using (var wc = new WebClient())
                    {
                        wc.Headers.Add("User-Agent", "Mozilla/5.0");
                        return wc.DownloadData(url);
                    }
                });
                Bitmap bmp;
                using (var ms = new MemoryStream(data))
                    bmp = new Bitmap(ms);
                _picPreviewUrl.Image = bmp;
                _picPreviewUrl.Refresh();
            }
            catch
            {
                _picPreviewUrl.Image = null;
            }
        }

        private void BtnAgregarUrl_Click(object sender, EventArgs e)
        {
            var url = _txtNuevaUrl.Text.Trim();
            if (string.IsNullOrEmpty(url))
            {
                MessageBox.Show("Ingresá una URL válida.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (_cmbSelArticulo.SelectedItem == null)
            {
                MessageBox.Show("Seleccioná un artículo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var art = (Models.Articulo)_cmbSelArticulo.SelectedItem;
            try
            {
                _imagenController.Add(new Models.Imagen { IdArticulo = art.Id, ImagenUrl = url });
                _txtNuevaUrl.Clear();
                CargarImagenesDeArticulo();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar imagen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEliminarUrl_Click(object sender, EventArgs e)
        {
            if (_dgvImagenes.CurrentRow?.DataBoundItem is Models.Imagen img)
            {
                var confirm = MessageBox.Show("¿Eliminar esta imagen?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        _imagenController.Delete(img.Id);
                        CargarImagenesDeArticulo();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al eliminar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccioná una imagen para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

