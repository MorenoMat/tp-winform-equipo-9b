namespace winform_app.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // ToolStrip
        private System.Windows.Forms.ToolStrip _toolStrip;
        private System.Windows.Forms.ToolStripButton _btnNuevo;
        private System.Windows.Forms.ToolStripButton _btnEditar;
        private System.Windows.Forms.ToolStripButton _btnEliminar;
        private System.Windows.Forms.ToolStripSeparator _toolStripSeparator;

        // SplitContainer principal (izquierda: filtros | derecha: grilla + detalle)
        private System.Windows.Forms.SplitContainer _splitMain;
        // SplitContainer secundario (arriba: grilla | abajo: detalle)
        private System.Windows.Forms.SplitContainer _splitDetail;

        // Panel filtros (izquierda)
        private System.Windows.Forms.GroupBox _grpFiltros;
        private System.Windows.Forms.Label _lblBuscarNombre;
        private System.Windows.Forms.TextBox _txtBuscar;
        private System.Windows.Forms.Label _lblMarca;
        private System.Windows.Forms.ComboBox _cmbMarca;
        private System.Windows.Forms.Label _lblCategoria;
        private System.Windows.Forms.ComboBox _cmbCategoria;
        private System.Windows.Forms.Button _btnBuscar;
        private System.Windows.Forms.Button _btnLimpiar;

        // DataGridView (centro)
        private System.Windows.Forms.DataGridView _dgvArticulos;

        // Panel detalle (derecha/abajo)
        private System.Windows.Forms.GroupBox _grpDetalle;
        private System.Windows.Forms.Label _lblDetalleCodigo;
        private System.Windows.Forms.Label _lblDetalleCodigoVal;
        private System.Windows.Forms.Label _lblDetalleNombre;
        private System.Windows.Forms.Label _lblDetalleNombreVal;
        private System.Windows.Forms.Label _lblDetallePrecio;
        private System.Windows.Forms.Label _lblDetallePrecioVal;
        private System.Windows.Forms.Label _lblDetalleMarca;
        private System.Windows.Forms.Label _lblDetalleMarcaVal;
        private System.Windows.Forms.Label _lblDetalleCategoria;
        private System.Windows.Forms.Label _lblDetalleCategoriaVal;
        private System.Windows.Forms.Label _lblDetalleDesc;
        private System.Windows.Forms.Label _lblDetalleDescVal;

        // StatusStrip
        private System.Windows.Forms.StatusStrip _statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel _lblStatus;

        // PictureBox imagen artículo
        private System.Windows.Forms.PictureBox _picImagen;

        // TabControl principal
        private System.Windows.Forms.TabControl _tabControl;
        private System.Windows.Forms.TabPage _tabArticulos;
        private System.Windows.Forms.TabPage _tabImagenes;

        // Tab Imágenes
        private System.Windows.Forms.GroupBox _grpGestionImagenes;
        private System.Windows.Forms.Label _lblSelArticulo;
        private System.Windows.Forms.ComboBox _cmbSelArticulo;
        private System.Windows.Forms.Label _lblImagenesCargadas;
        private System.Windows.Forms.DataGridView _dgvImagenes;
        private System.Windows.Forms.PictureBox _picPreviewUrl;
        private System.Windows.Forms.Label _lblNuevaUrl;
        private System.Windows.Forms.TextBox _txtNuevaUrl;
        private System.Windows.Forms.Button _btnAgregarUrl;
        private System.Windows.Forms.Button _btnEliminarUrl;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this._toolStrip = new System.Windows.Forms.ToolStrip();
            this._btnNuevo = new System.Windows.Forms.ToolStripButton();
            this._toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this._btnEditar = new System.Windows.Forms.ToolStripButton();
            this._btnEliminar = new System.Windows.Forms.ToolStripButton();
            this._splitMain = new System.Windows.Forms.SplitContainer();
            this._grpFiltros = new System.Windows.Forms.GroupBox();
            this._btnLimpiar = new System.Windows.Forms.Button();
            this._btnBuscar = new System.Windows.Forms.Button();
            this._cmbCategoria = new System.Windows.Forms.ComboBox();
            this._lblCategoria = new System.Windows.Forms.Label();
            this._cmbMarca = new System.Windows.Forms.ComboBox();
            this._lblMarca = new System.Windows.Forms.Label();
            this._txtBuscar = new System.Windows.Forms.TextBox();
            this._lblBuscarNombre = new System.Windows.Forms.Label();
            this._splitDetail = new System.Windows.Forms.SplitContainer();
            this._dgvArticulos = new System.Windows.Forms.DataGridView();
            this._grpDetalle = new System.Windows.Forms.GroupBox();
            this._picImagen = new System.Windows.Forms.PictureBox();
            this._lblDetalleCodigo = new System.Windows.Forms.Label();
            this._lblDetalleCodigoVal = new System.Windows.Forms.Label();
            this._lblDetalleNombre = new System.Windows.Forms.Label();
            this._lblDetalleNombreVal = new System.Windows.Forms.Label();
            this._lblDetallePrecio = new System.Windows.Forms.Label();
            this._lblDetallePrecioVal = new System.Windows.Forms.Label();
            this._lblDetalleMarca = new System.Windows.Forms.Label();
            this._lblDetalleMarcaVal = new System.Windows.Forms.Label();
            this._lblDetalleCategoria = new System.Windows.Forms.Label();
            this._lblDetalleCategoriaVal = new System.Windows.Forms.Label();
            this._lblDetalleDesc = new System.Windows.Forms.Label();
            this._lblDetalleDescVal = new System.Windows.Forms.Label();
            this._tabControl = new System.Windows.Forms.TabControl();
            this._tabArticulos = new System.Windows.Forms.TabPage();
            this._tabImagenes = new System.Windows.Forms.TabPage();
            this._grpGestionImagenes = new System.Windows.Forms.GroupBox();
            this._lblSelArticulo = new System.Windows.Forms.Label();
            this._cmbSelArticulo = new System.Windows.Forms.ComboBox();
            this._lblImagenesCargadas = new System.Windows.Forms.Label();
            this._dgvImagenes = new System.Windows.Forms.DataGridView();
            this._picPreviewUrl = new System.Windows.Forms.PictureBox();
            this._lblNuevaUrl = new System.Windows.Forms.Label();
            this._txtNuevaUrl = new System.Windows.Forms.TextBox();
            this._btnAgregarUrl = new System.Windows.Forms.Button();
            this._btnEliminarUrl = new System.Windows.Forms.Button();
            this._statusStrip = new System.Windows.Forms.StatusStrip();
            this._lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this._toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._splitMain)).BeginInit();
            this._splitMain.Panel1.SuspendLayout();
            this._splitMain.Panel2.SuspendLayout();
            this._splitMain.SuspendLayout();
            this._grpFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._splitDetail)).BeginInit();
            this._splitDetail.Panel1.SuspendLayout();
            this._splitDetail.Panel2.SuspendLayout();
            this._splitDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dgvArticulos)).BeginInit();
            this._grpDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._picImagen)).BeginInit();
            this._tabControl.SuspendLayout();
            this._tabArticulos.SuspendLayout();
            this._tabImagenes.SuspendLayout();
            this._grpGestionImagenes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dgvImagenes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._picPreviewUrl)).BeginInit();
            this._statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // _toolStrip
            // 
            this._toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._btnNuevo,
            this._toolStripSeparator,
            this._btnEditar,
            this._btnEliminar});
            this._toolStrip.Location = new System.Drawing.Point(0, 0);
            this._toolStrip.Name = "_toolStrip";
            this._toolStrip.Size = new System.Drawing.Size(1000, 25);
            this._toolStrip.TabIndex = 0;
            // 
            // _btnNuevo
            // 
            this._btnNuevo.Name = "_btnNuevo";
            this._btnNuevo.Size = new System.Drawing.Size(46, 22);
            this._btnNuevo.Text = "Nuevo";
            this._btnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // _toolStripSeparator
            // 
            this._toolStripSeparator.Name = "_toolStripSeparator";
            this._toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // _btnEditar
            // 
            this._btnEditar.Name = "_btnEditar";
            this._btnEditar.Size = new System.Drawing.Size(41, 22);
            this._btnEditar.Text = "Editar";
            this._btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // _btnEliminar
            // 
            this._btnEliminar.Name = "_btnEliminar";
            this._btnEliminar.Size = new System.Drawing.Size(54, 22);
            this._btnEliminar.Text = "Eliminar";
            this._btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // _splitMain
            // 
            this._splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this._splitMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this._splitMain.Location = new System.Drawing.Point(3, 3);
            this._splitMain.Name = "_splitMain";
            // 
            // _splitMain.Panel1
            // 
            this._splitMain.Panel1.Controls.Add(this._grpFiltros);
            // 
            // _splitMain.Panel2
            // 
            this._splitMain.Panel2.Controls.Add(this._splitDetail);
            this._splitMain.Size = new System.Drawing.Size(986, 541);
            this._splitMain.SplitterDistance = 200;
            this._splitMain.TabIndex = 1;
            // 
            // _grpFiltros
            // 
            this._grpFiltros.Controls.Add(this._btnLimpiar);
            this._grpFiltros.Controls.Add(this._btnBuscar);
            this._grpFiltros.Controls.Add(this._cmbCategoria);
            this._grpFiltros.Controls.Add(this._lblCategoria);
            this._grpFiltros.Controls.Add(this._cmbMarca);
            this._grpFiltros.Controls.Add(this._lblMarca);
            this._grpFiltros.Controls.Add(this._txtBuscar);
            this._grpFiltros.Controls.Add(this._lblBuscarNombre);
            this._grpFiltros.Dock = System.Windows.Forms.DockStyle.Fill;
            this._grpFiltros.Location = new System.Drawing.Point(0, 0);
            this._grpFiltros.Name = "_grpFiltros";
            this._grpFiltros.Size = new System.Drawing.Size(200, 541);
            this._grpFiltros.TabIndex = 0;
            this._grpFiltros.TabStop = false;
            this._grpFiltros.Text = "Filtros";
            // 
            // _btnLimpiar
            // 
            this._btnLimpiar.Location = new System.Drawing.Point(98, 185);
            this._btnLimpiar.Name = "_btnLimpiar";
            this._btnLimpiar.Size = new System.Drawing.Size(80, 23);
            this._btnLimpiar.TabIndex = 4;
            this._btnLimpiar.Text = "Limpiar";
            this._btnLimpiar.UseVisualStyleBackColor = true;
            this._btnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // _btnBuscar
            // 
            this._btnBuscar.Location = new System.Drawing.Point(8, 185);
            this._btnBuscar.Name = "_btnBuscar";
            this._btnBuscar.Size = new System.Drawing.Size(80, 23);
            this._btnBuscar.TabIndex = 3;
            this._btnBuscar.Text = "Buscar";
            this._btnBuscar.UseVisualStyleBackColor = true;
            this._btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // _cmbCategoria
            // 
            this._cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbCategoria.Location = new System.Drawing.Point(8, 146);
            this._cmbCategoria.Name = "_cmbCategoria";
            this._cmbCategoria.Size = new System.Drawing.Size(170, 21);
            this._cmbCategoria.TabIndex = 2;
            this._cmbCategoria.SelectedIndexChanged += new System.EventHandler(this._cmbCategoria_SelectedIndexChanged);
            // 
            // _lblCategoria
            // 
            this._lblCategoria.Location = new System.Drawing.Point(8, 126);
            this._lblCategoria.Name = "_lblCategoria";
            this._lblCategoria.Size = new System.Drawing.Size(70, 16);
            this._lblCategoria.TabIndex = 5;
            this._lblCategoria.Text = "Categoría:";
            this._lblCategoria.Click += new System.EventHandler(this._lblCategoria_Click);
            // 
            // _cmbMarca
            // 
            this._cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbMarca.Location = new System.Drawing.Point(8, 95);
            this._cmbMarca.Name = "_cmbMarca";
            this._cmbMarca.Size = new System.Drawing.Size(170, 21);
            this._cmbMarca.TabIndex = 1;
            this._cmbMarca.SelectedIndexChanged += new System.EventHandler(this._cmbMarca_SelectedIndexChanged);
            // 
            // _lblMarca
            // 
            this._lblMarca.Location = new System.Drawing.Point(8, 75);
            this._lblMarca.Name = "_lblMarca";
            this._lblMarca.Size = new System.Drawing.Size(70, 16);
            this._lblMarca.TabIndex = 6;
            this._lblMarca.Text = "Marca:";
            this._lblMarca.Click += new System.EventHandler(this._lblMarca_Click);
            // 
            // _txtBuscar
            // 
            this._txtBuscar.Location = new System.Drawing.Point(8, 44);
            this._txtBuscar.Name = "_txtBuscar";
            this._txtBuscar.Size = new System.Drawing.Size(170, 20);
            this._txtBuscar.TabIndex = 0;
            this._txtBuscar.TextChanged += new System.EventHandler(this._txtBuscarNombre_TextChanged);
            // 
            // _lblBuscarNombre
            // 
            this._lblBuscarNombre.Location = new System.Drawing.Point(8, 24);
            this._lblBuscarNombre.Name = "_lblBuscarNombre";
            this._lblBuscarNombre.Size = new System.Drawing.Size(111, 16);
            this._lblBuscarNombre.TabIndex = 7;
            this._lblBuscarNombre.Text = "Buscar por nombre:";
            this._lblBuscarNombre.Click += new System.EventHandler(this._lblBuscarNombre_Click);
            // 
            // _splitDetail
            // 
            this._splitDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this._splitDetail.Location = new System.Drawing.Point(0, 0);
            this._splitDetail.Name = "_splitDetail";
            this._splitDetail.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // _splitDetail.Panel1
            // 
            this._splitDetail.Panel1.Controls.Add(this._dgvArticulos);
            // 
            // _splitDetail.Panel2
            // 
            this._splitDetail.Panel2.Controls.Add(this._grpDetalle);
            this._splitDetail.Size = new System.Drawing.Size(782, 541);
            this._splitDetail.SplitterDistance = 321;
            this._splitDetail.TabIndex = 0;
            // 
            // _dgvArticulos
            // 
            this._dgvArticulos.AllowUserToAddRows = false;
            this._dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgvArticulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dgvArticulos.Location = new System.Drawing.Point(0, 0);
            this._dgvArticulos.MultiSelect = false;
            this._dgvArticulos.Name = "_dgvArticulos";
            this._dgvArticulos.ReadOnly = true;
            this._dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._dgvArticulos.Size = new System.Drawing.Size(782, 321);
            this._dgvArticulos.TabIndex = 0;
            this._dgvArticulos.SelectionChanged += new System.EventHandler(this.DgvArticulos_SelectionChanged);
            // 
            // _grpDetalle
            // 
            this._grpDetalle.Controls.Add(this._picImagen);
            this._grpDetalle.Controls.Add(this._lblDetalleCodigo);
            this._grpDetalle.Controls.Add(this._lblDetalleCodigoVal);
            this._grpDetalle.Controls.Add(this._lblDetalleNombre);
            this._grpDetalle.Controls.Add(this._lblDetalleNombreVal);
            this._grpDetalle.Controls.Add(this._lblDetallePrecio);
            this._grpDetalle.Controls.Add(this._lblDetallePrecioVal);
            this._grpDetalle.Controls.Add(this._lblDetalleMarca);
            this._grpDetalle.Controls.Add(this._lblDetalleMarcaVal);
            this._grpDetalle.Controls.Add(this._lblDetalleCategoria);
            this._grpDetalle.Controls.Add(this._lblDetalleCategoriaVal);
            this._grpDetalle.Controls.Add(this._lblDetalleDesc);
            this._grpDetalle.Controls.Add(this._lblDetalleDescVal);
            this._grpDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this._grpDetalle.Location = new System.Drawing.Point(0, 0);
            this._grpDetalle.Name = "_grpDetalle";
            this._grpDetalle.Size = new System.Drawing.Size(782, 216);
            this._grpDetalle.TabIndex = 0;
            this._grpDetalle.TabStop = false;
            this._grpDetalle.Text = "Detalle";
            // 
            // _picImagen
            // 
            this._picImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._picImagen.Location = new System.Drawing.Point(610, 20);
            this._picImagen.Name = "_picImagen";
            this._picImagen.Size = new System.Drawing.Size(160, 160);
            this._picImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._picImagen.TabIndex = 12;
            this._picImagen.TabStop = false;
            this._picImagen.Click += new System.EventHandler(this._picImagen_Click);
            // 
            // _lblDetalleCodigo
            // 
            this._lblDetalleCodigo.Location = new System.Drawing.Point(8, 20);
            this._lblDetalleCodigo.Name = "_lblDetalleCodigo";
            this._lblDetalleCodigo.Size = new System.Drawing.Size(80, 16);
            this._lblDetalleCodigo.TabIndex = 0;
            this._lblDetalleCodigo.Text = "Código:";
            // 
            // _lblDetalleCodigoVal
            // 
            this._lblDetalleCodigoVal.Location = new System.Drawing.Point(95, 20);
            this._lblDetalleCodigoVal.Name = "_lblDetalleCodigoVal";
            this._lblDetalleCodigoVal.Size = new System.Drawing.Size(200, 16);
            this._lblDetalleCodigoVal.TabIndex = 1;
            this._lblDetalleCodigoVal.Text = "-";
            // 
            // _lblDetalleNombre
            // 
            this._lblDetalleNombre.Location = new System.Drawing.Point(8, 44);
            this._lblDetalleNombre.Name = "_lblDetalleNombre";
            this._lblDetalleNombre.Size = new System.Drawing.Size(80, 16);
            this._lblDetalleNombre.TabIndex = 2;
            this._lblDetalleNombre.Text = "Nombre:";
            // 
            // _lblDetalleNombreVal
            // 
            this._lblDetalleNombreVal.Location = new System.Drawing.Point(95, 44);
            this._lblDetalleNombreVal.Name = "_lblDetalleNombreVal";
            this._lblDetalleNombreVal.Size = new System.Drawing.Size(300, 16);
            this._lblDetalleNombreVal.TabIndex = 3;
            this._lblDetalleNombreVal.Text = "-";
            // 
            // _lblDetallePrecio
            // 
            this._lblDetallePrecio.Location = new System.Drawing.Point(8, 68);
            this._lblDetallePrecio.Name = "_lblDetallePrecio";
            this._lblDetallePrecio.Size = new System.Drawing.Size(80, 16);
            this._lblDetallePrecio.TabIndex = 4;
            this._lblDetallePrecio.Text = "Precio:";
            // 
            // _lblDetallePrecioVal
            // 
            this._lblDetallePrecioVal.Location = new System.Drawing.Point(95, 68);
            this._lblDetallePrecioVal.Name = "_lblDetallePrecioVal";
            this._lblDetallePrecioVal.Size = new System.Drawing.Size(150, 16);
            this._lblDetallePrecioVal.TabIndex = 5;
            this._lblDetallePrecioVal.Text = "-";
            // 
            // _lblDetalleMarca
            // 
            this._lblDetalleMarca.Location = new System.Drawing.Point(8, 92);
            this._lblDetalleMarca.Name = "_lblDetalleMarca";
            this._lblDetalleMarca.Size = new System.Drawing.Size(80, 16);
            this._lblDetalleMarca.TabIndex = 6;
            this._lblDetalleMarca.Text = "Marca:";
            // 
            // _lblDetalleMarcaVal
            // 
            this._lblDetalleMarcaVal.Location = new System.Drawing.Point(95, 92);
            this._lblDetalleMarcaVal.Name = "_lblDetalleMarcaVal";
            this._lblDetalleMarcaVal.Size = new System.Drawing.Size(200, 16);
            this._lblDetalleMarcaVal.TabIndex = 7;
            this._lblDetalleMarcaVal.Text = "-";
            // 
            // _lblDetalleCategoria
            // 
            this._lblDetalleCategoria.Location = new System.Drawing.Point(8, 116);
            this._lblDetalleCategoria.Name = "_lblDetalleCategoria";
            this._lblDetalleCategoria.Size = new System.Drawing.Size(80, 16);
            this._lblDetalleCategoria.TabIndex = 8;
            this._lblDetalleCategoria.Text = "Categoría:";
            // 
            // _lblDetalleCategoriaVal
            // 
            this._lblDetalleCategoriaVal.Location = new System.Drawing.Point(95, 116);
            this._lblDetalleCategoriaVal.Name = "_lblDetalleCategoriaVal";
            this._lblDetalleCategoriaVal.Size = new System.Drawing.Size(200, 16);
            this._lblDetalleCategoriaVal.TabIndex = 9;
            this._lblDetalleCategoriaVal.Text = "-";
            // 
            // _lblDetalleDesc
            // 
            this._lblDetalleDesc.Location = new System.Drawing.Point(8, 140);
            this._lblDetalleDesc.Name = "_lblDetalleDesc";
            this._lblDetalleDesc.Size = new System.Drawing.Size(80, 16);
            this._lblDetalleDesc.TabIndex = 10;
            this._lblDetalleDesc.Text = "Descripción:";
            // 
            // _lblDetalleDescVal
            // 
            this._lblDetalleDescVal.Location = new System.Drawing.Point(95, 140);
            this._lblDetalleDescVal.Name = "_lblDetalleDescVal";
            this._lblDetalleDescVal.Size = new System.Drawing.Size(350, 40);
            this._lblDetalleDescVal.TabIndex = 11;
            this._lblDetalleDescVal.Text = "-";
            // 
            // _tabControl
            // 
            this._tabControl.Controls.Add(this._tabArticulos);
            this._tabControl.Controls.Add(this._tabImagenes);
            this._tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tabControl.Location = new System.Drawing.Point(0, 25);
            this._tabControl.Name = "_tabControl";
            this._tabControl.SelectedIndex = 0;
            this._tabControl.Size = new System.Drawing.Size(1000, 573);
            this._tabControl.TabIndex = 1;
            // 
            // _tabArticulos
            // 
            this._tabArticulos.Controls.Add(this._splitMain);
            this._tabArticulos.Location = new System.Drawing.Point(4, 22);
            this._tabArticulos.Name = "_tabArticulos";
            this._tabArticulos.Padding = new System.Windows.Forms.Padding(3);
            this._tabArticulos.Size = new System.Drawing.Size(992, 547);
            this._tabArticulos.TabIndex = 0;
            this._tabArticulos.Text = "Artículos";
            this._tabArticulos.UseVisualStyleBackColor = true;
            // 
            // _tabImagenes
            // 
            this._tabImagenes.Controls.Add(this._grpGestionImagenes);
            this._tabImagenes.Location = new System.Drawing.Point(4, 22);
            this._tabImagenes.Name = "_tabImagenes";
            this._tabImagenes.Padding = new System.Windows.Forms.Padding(3);
            this._tabImagenes.Size = new System.Drawing.Size(192, 74);
            this._tabImagenes.TabIndex = 1;
            this._tabImagenes.Text = "Imágenes";
            this._tabImagenes.UseVisualStyleBackColor = true;
            // 
            // _grpGestionImagenes
            // 
            this._grpGestionImagenes.Controls.Add(this._lblSelArticulo);
            this._grpGestionImagenes.Controls.Add(this._cmbSelArticulo);
            this._grpGestionImagenes.Controls.Add(this._lblImagenesCargadas);
            this._grpGestionImagenes.Controls.Add(this._dgvImagenes);
            this._grpGestionImagenes.Controls.Add(this._picPreviewUrl);
            this._grpGestionImagenes.Controls.Add(this._lblNuevaUrl);
            this._grpGestionImagenes.Controls.Add(this._txtNuevaUrl);
            this._grpGestionImagenes.Controls.Add(this._btnAgregarUrl);
            this._grpGestionImagenes.Controls.Add(this._btnEliminarUrl);
            this._grpGestionImagenes.Dock = System.Windows.Forms.DockStyle.Fill;
            this._grpGestionImagenes.Location = new System.Drawing.Point(3, 3);
            this._grpGestionImagenes.Name = "_grpGestionImagenes";
            this._grpGestionImagenes.Size = new System.Drawing.Size(186, 68);
            this._grpGestionImagenes.TabIndex = 0;
            this._grpGestionImagenes.TabStop = false;
            this._grpGestionImagenes.Text = "Gestión de Imágenes";
            // 
            // _lblSelArticulo
            // 
            this._lblSelArticulo.Location = new System.Drawing.Point(8, 24);
            this._lblSelArticulo.Name = "_lblSelArticulo";
            this._lblSelArticulo.Size = new System.Drawing.Size(62, 16);
            this._lblSelArticulo.TabIndex = 0;
            this._lblSelArticulo.Text = "Artículo:";
            // 
            // _cmbSelArticulo
            // 
            this._cmbSelArticulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbSelArticulo.Location = new System.Drawing.Point(76, 21);
            this._cmbSelArticulo.Name = "_cmbSelArticulo";
            this._cmbSelArticulo.Size = new System.Drawing.Size(360, 21);
            this._cmbSelArticulo.TabIndex = 0;
            this._cmbSelArticulo.SelectedIndexChanged += new System.EventHandler(this.CmbSelArticulo_SelectedIndexChanged);
            // 
            // _lblImagenesCargadas
            // 
            this._lblImagenesCargadas.Location = new System.Drawing.Point(8, 55);
            this._lblImagenesCargadas.Name = "_lblImagenesCargadas";
            this._lblImagenesCargadas.Size = new System.Drawing.Size(140, 16);
            this._lblImagenesCargadas.TabIndex = 1;
            this._lblImagenesCargadas.Text = "Imágenes cargadas:";
            // 
            // _dgvImagenes
            // 
            this._dgvImagenes.AllowUserToAddRows = false;
            this._dgvImagenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgvImagenes.Location = new System.Drawing.Point(8, 75);
            this._dgvImagenes.MultiSelect = false;
            this._dgvImagenes.Name = "_dgvImagenes";
            this._dgvImagenes.ReadOnly = true;
            this._dgvImagenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._dgvImagenes.Size = new System.Drawing.Size(580, 420);
            this._dgvImagenes.TabIndex = 1;
            this._dgvImagenes.SelectionChanged += new System.EventHandler(this.DgvImagenes_SelectionChanged);
            // 
            // _picPreviewUrl
            // 
            this._picPreviewUrl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._picPreviewUrl.Location = new System.Drawing.Point(606, 75);
            this._picPreviewUrl.Name = "_picPreviewUrl";
            this._picPreviewUrl.Size = new System.Drawing.Size(200, 200);
            this._picPreviewUrl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._picPreviewUrl.TabIndex = 2;
            this._picPreviewUrl.TabStop = false;
            // 
            // _lblNuevaUrl
            // 
            this._lblNuevaUrl.Location = new System.Drawing.Point(8, 507);
            this._lblNuevaUrl.Name = "_lblNuevaUrl";
            this._lblNuevaUrl.Size = new System.Drawing.Size(65, 16);
            this._lblNuevaUrl.TabIndex = 3;
            this._lblNuevaUrl.Text = "Nueva URL:";
            // 
            // _txtNuevaUrl
            // 
            this._txtNuevaUrl.Location = new System.Drawing.Point(80, 504);
            this._txtNuevaUrl.Name = "_txtNuevaUrl";
            this._txtNuevaUrl.Size = new System.Drawing.Size(490, 20);
            this._txtNuevaUrl.TabIndex = 2;
            // 
            // _btnAgregarUrl
            // 
            this._btnAgregarUrl.Location = new System.Drawing.Point(580, 502);
            this._btnAgregarUrl.Name = "_btnAgregarUrl";
            this._btnAgregarUrl.Size = new System.Drawing.Size(80, 23);
            this._btnAgregarUrl.TabIndex = 3;
            this._btnAgregarUrl.Text = "Agregar";
            this._btnAgregarUrl.UseVisualStyleBackColor = true;
            this._btnAgregarUrl.Click += new System.EventHandler(this.BtnAgregarUrl_Click);
            // 
            // _btnEliminarUrl
            // 
            this._btnEliminarUrl.Location = new System.Drawing.Point(670, 502);
            this._btnEliminarUrl.Name = "_btnEliminarUrl";
            this._btnEliminarUrl.Size = new System.Drawing.Size(80, 23);
            this._btnEliminarUrl.TabIndex = 4;
            this._btnEliminarUrl.Text = "Eliminar";
            this._btnEliminarUrl.UseVisualStyleBackColor = true;
            this._btnEliminarUrl.Click += new System.EventHandler(this.BtnEliminarUrl_Click);
            // 
            // _statusStrip
            // 
            this._statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._lblStatus});
            this._statusStrip.Location = new System.Drawing.Point(0, 598);
            this._statusStrip.Name = "_statusStrip";
            this._statusStrip.Size = new System.Drawing.Size(1000, 22);
            this._statusStrip.TabIndex = 2;
            // 
            // _lblStatus
            // 
            this._lblStatus.Name = "_lblStatus";
            this._lblStatus.Size = new System.Drawing.Size(32, 17);
            this._lblStatus.Text = "Listo";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1000, 620);
            this.Controls.Add(this._tabControl);
            this.Controls.Add(this._toolStrip);
            this.Controls.Add(this._statusStrip);
            this.Name = "MainForm";
            this.Text = "Gestión de Artículos";
            this._toolStrip.ResumeLayout(false);
            this._toolStrip.PerformLayout();
            this._splitMain.Panel1.ResumeLayout(false);
            this._splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._splitMain)).EndInit();
            this._splitMain.ResumeLayout(false);
            this._grpFiltros.ResumeLayout(false);
            this._grpFiltros.PerformLayout();
            this._splitDetail.Panel1.ResumeLayout(false);
            this._splitDetail.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._splitDetail)).EndInit();
            this._splitDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._dgvArticulos)).EndInit();
            this._grpDetalle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._picImagen)).EndInit();
            this._tabControl.ResumeLayout(false);
            this._tabArticulos.ResumeLayout(false);
            this._tabImagenes.ResumeLayout(false);
            this._grpGestionImagenes.ResumeLayout(false);
            this._grpGestionImagenes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dgvImagenes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._picPreviewUrl)).EndInit();
            this._statusStrip.ResumeLayout(false);
            this._statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
