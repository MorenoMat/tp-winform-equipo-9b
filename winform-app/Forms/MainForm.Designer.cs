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
        private System.Windows.Forms.Label _lblBuscar;
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
            this.components = new System.ComponentModel.Container();
            this._toolStrip = new System.Windows.Forms.ToolStrip();
            this._btnNuevo = new System.Windows.Forms.ToolStripButton();
            this._toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this._btnEditar = new System.Windows.Forms.ToolStripButton();
            this._btnEliminar = new System.Windows.Forms.ToolStripButton();
            this._splitMain = new System.Windows.Forms.SplitContainer();
            this._grpFiltros = new System.Windows.Forms.GroupBox();
            this._lblBuscar = new System.Windows.Forms.Label();
            this._txtBuscar = new System.Windows.Forms.TextBox();
            this._lblMarca = new System.Windows.Forms.Label();
            this._cmbMarca = new System.Windows.Forms.ComboBox();
            this._lblCategoria = new System.Windows.Forms.Label();
            this._cmbCategoria = new System.Windows.Forms.ComboBox();
            this._btnBuscar = new System.Windows.Forms.Button();
            this._btnLimpiar = new System.Windows.Forms.Button();
            this._splitDetail = new System.Windows.Forms.SplitContainer();
            this._dgvArticulos = new System.Windows.Forms.DataGridView();
            this._grpDetalle = new System.Windows.Forms.GroupBox();
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
            this._statusStrip = new System.Windows.Forms.StatusStrip();
            this._lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
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
            this._statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // _toolStrip
            // 
            this._toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this._btnNuevo, this._toolStripSeparator, this._btnEditar, this._btnEliminar });
            this._toolStrip.Location = new System.Drawing.Point(0, 0);
            this._toolStrip.Name = "_toolStrip";
            this._toolStrip.Size = new System.Drawing.Size(1000, 25);
            this._toolStrip.TabIndex = 0;
            // 
            // _btnNuevo
            // 
            this._btnNuevo.Name = "_btnNuevo";
            this._btnNuevo.Size = new System.Drawing.Size(49, 22);
            this._btnNuevo.Text = "Nuevo";
            this._btnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // _btnEditar
            // 
            this._btnEditar.Name = "_btnEditar";
            this._btnEditar.Size = new System.Drawing.Size(49, 22);
            this._btnEditar.Text = "Editar";
            this._btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // _btnEliminar
            // 
            this._btnEliminar.Name = "_btnEliminar";
            this._btnEliminar.Size = new System.Drawing.Size(63, 22);
            this._btnEliminar.Text = "Eliminar";
            this._btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // _splitMain
            // 
            this._splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this._splitMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this._splitMain.Location = new System.Drawing.Point(0, 25);
            this._splitMain.Name = "_splitMain";
            this._splitMain.Size = new System.Drawing.Size(1000, 573);
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
            this._grpFiltros.Controls.Add(this._lblBuscar);
            this._grpFiltros.Dock = System.Windows.Forms.DockStyle.Fill;
            this._grpFiltros.Location = new System.Drawing.Point(0, 0);
            this._grpFiltros.Name = "_grpFiltros";
            this._grpFiltros.Size = new System.Drawing.Size(197, 573);
            this._grpFiltros.TabIndex = 0;
            this._grpFiltros.TabStop = false;
            this._grpFiltros.Text = "Filtros";
            // 
            // _lblBuscar
            // 
            this._lblBuscar.Location = new System.Drawing.Point(8, 24);
            this._lblBuscar.Name = "_lblBuscar";
            this._lblBuscar.Size = new System.Drawing.Size(70, 16);
            this._lblBuscar.Text = "Buscar:";
            // 
            // _txtBuscar
            // 
            this._txtBuscar.Location = new System.Drawing.Point(8, 44);
            this._txtBuscar.Name = "_txtBuscar";
            this._txtBuscar.Size = new System.Drawing.Size(170, 20);
            this._txtBuscar.TabIndex = 0;
            // 
            // _lblMarca
            // 
            this._lblMarca.Location = new System.Drawing.Point(8, 75);
            this._lblMarca.Name = "_lblMarca";
            this._lblMarca.Size = new System.Drawing.Size(70, 16);
            this._lblMarca.Text = "Marca:";
            // 
            // _cmbMarca
            // 
            this._cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbMarca.Location = new System.Drawing.Point(8, 95);
            this._cmbMarca.Name = "_cmbMarca";
            this._cmbMarca.Size = new System.Drawing.Size(170, 21);
            this._cmbMarca.TabIndex = 1;
            // 
            // _lblCategoria
            // 
            this._lblCategoria.Location = new System.Drawing.Point(8, 126);
            this._lblCategoria.Name = "_lblCategoria";
            this._lblCategoria.Size = new System.Drawing.Size(70, 16);
            this._lblCategoria.Text = "Categoría:";
            // 
            // _cmbCategoria
            // 
            this._cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbCategoria.Location = new System.Drawing.Point(8, 146);
            this._cmbCategoria.Name = "_cmbCategoria";
            this._cmbCategoria.Size = new System.Drawing.Size(170, 21);
            this._cmbCategoria.TabIndex = 2;
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
            // _splitDetail
            // 
            this._splitDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this._splitDetail.Location = new System.Drawing.Point(0, 0);
            this._splitDetail.Name = "_splitDetail";
            this._splitDetail.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this._splitDetail.Size = new System.Drawing.Size(797, 573);
            this._splitDetail.SplitterDistance = 340;
            this._splitDetail.TabIndex = 0;
            // 
            // _dgvArticulos
            // 
            this._dgvArticulos.AllowUserToAddRows = false;
            this._dgvArticulos.AutoGenerateColumns = false;
            this._dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgvArticulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dgvArticulos.Location = new System.Drawing.Point(0, 0);
            this._dgvArticulos.MultiSelect = false;
            this._dgvArticulos.Name = "_dgvArticulos";
            this._dgvArticulos.ReadOnly = true;
            this._dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._dgvArticulos.Size = new System.Drawing.Size(797, 340);
            this._dgvArticulos.TabIndex = 0;
            this._dgvArticulos.SelectionChanged += new System.EventHandler(this.DgvArticulos_SelectionChanged);
            // Columnas
            var colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colId.DataPropertyName = "Id";
            colId.HeaderText = "ID";
            colId.Name = "colId";
            colId.Width = 50;
            var colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colCodigo.DataPropertyName = "Codigo";
            colCodigo.HeaderText = "Código";
            colCodigo.Name = "colCodigo";
            colCodigo.Width = 80;
            var colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colNombre.DataPropertyName = "Nombre";
            colNombre.HeaderText = "Nombre";
            colNombre.Name = "colNombre";
            colNombre.Width = 200;
            var colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colPrecio.DataPropertyName = "Precio";
            colPrecio.HeaderText = "Precio";
            colPrecio.Name = "colPrecio";
            colPrecio.Width = 90;
            var colMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colMarca.DataPropertyName = "MarcaNombre";
            colMarca.HeaderText = "Marca";
            colMarca.Name = "colMarca";
            colMarca.Width = 100;
            var colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colCategoria.DataPropertyName = "CategoriaNombre";
            colCategoria.HeaderText = "Categoría";
            colCategoria.Name = "colCategoria";
            colCategoria.Width = 100;
            this._dgvArticulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                colId, colCodigo, colNombre, colPrecio, colMarca, colCategoria });
            // 
            // _grpDetalle
            // 
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
            this._grpDetalle.Size = new System.Drawing.Size(797, 229);
            this._grpDetalle.TabIndex = 0;
            this._grpDetalle.TabStop = false;
            this._grpDetalle.Text = "Detalle";
            // 
            // Labels detalle
            // 
            this._lblDetalleCodigo.Location = new System.Drawing.Point(8, 20);
            this._lblDetalleCodigo.Name = "_lblDetalleCodigo";
            this._lblDetalleCodigo.Size = new System.Drawing.Size(80, 16);
            this._lblDetalleCodigo.Text = "Código:";
            this._lblDetalleCodigoVal.Location = new System.Drawing.Point(95, 20);
            this._lblDetalleCodigoVal.Name = "_lblDetalleCodigoVal";
            this._lblDetalleCodigoVal.Size = new System.Drawing.Size(200, 16);
            this._lblDetalleCodigoVal.Text = "-";
            this._lblDetalleNombre.Location = new System.Drawing.Point(8, 44);
            this._lblDetalleNombre.Name = "_lblDetalleNombre";
            this._lblDetalleNombre.Size = new System.Drawing.Size(80, 16);
            this._lblDetalleNombre.Text = "Nombre:";
            this._lblDetalleNombreVal.Location = new System.Drawing.Point(95, 44);
            this._lblDetalleNombreVal.Name = "_lblDetalleNombreVal";
            this._lblDetalleNombreVal.Size = new System.Drawing.Size(300, 16);
            this._lblDetalleNombreVal.Text = "-";
            this._lblDetallePrecio.Location = new System.Drawing.Point(8, 68);
            this._lblDetallePrecio.Name = "_lblDetallePrecio";
            this._lblDetallePrecio.Size = new System.Drawing.Size(80, 16);
            this._lblDetallePrecio.Text = "Precio:";
            this._lblDetallePrecioVal.Location = new System.Drawing.Point(95, 68);
            this._lblDetallePrecioVal.Name = "_lblDetallePrecioVal";
            this._lblDetallePrecioVal.Size = new System.Drawing.Size(150, 16);
            this._lblDetallePrecioVal.Text = "-";
            this._lblDetalleMarca.Location = new System.Drawing.Point(8, 92);
            this._lblDetalleMarca.Name = "_lblDetalleMarca";
            this._lblDetalleMarca.Size = new System.Drawing.Size(80, 16);
            this._lblDetalleMarca.Text = "Marca:";
            this._lblDetalleMarcaVal.Location = new System.Drawing.Point(95, 92);
            this._lblDetalleMarcaVal.Name = "_lblDetalleMarcaVal";
            this._lblDetalleMarcaVal.Size = new System.Drawing.Size(200, 16);
            this._lblDetalleMarcaVal.Text = "-";
            this._lblDetalleCategoria.Location = new System.Drawing.Point(8, 116);
            this._lblDetalleCategoria.Name = "_lblDetalleCategoria";
            this._lblDetalleCategoria.Size = new System.Drawing.Size(80, 16);
            this._lblDetalleCategoria.Text = "Categoría:";
            this._lblDetalleCategoriaVal.Location = new System.Drawing.Point(95, 116);
            this._lblDetalleCategoriaVal.Name = "_lblDetalleCategoriaVal";
            this._lblDetalleCategoriaVal.Size = new System.Drawing.Size(200, 16);
            this._lblDetalleCategoriaVal.Text = "-";
            this._lblDetalleDesc.Location = new System.Drawing.Point(8, 140);
            this._lblDetalleDesc.Name = "_lblDetalleDesc";
            this._lblDetalleDesc.Size = new System.Drawing.Size(80, 16);
            this._lblDetalleDesc.Text = "Descripción:";
            this._lblDetalleDescVal.Location = new System.Drawing.Point(95, 140);
            this._lblDetalleDescVal.Name = "_lblDetalleDescVal";
            this._lblDetalleDescVal.Size = new System.Drawing.Size(350, 40);
            this._lblDetalleDescVal.Text = "-";
            // 
            // _statusStrip
            // 
            this._statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this._lblStatus });
            this._statusStrip.Location = new System.Drawing.Point(0, 598);
            this._statusStrip.Name = "_statusStrip";
            this._statusStrip.Size = new System.Drawing.Size(1000, 22);
            this._statusStrip.TabIndex = 2;
            // 
            // _lblStatus
            // 
            this._lblStatus.Name = "_lblStatus";
            this._lblStatus.Size = new System.Drawing.Size(29, 17);
            this._lblStatus.Text = "Listo";
            // 
            // Panel1 y Panel2 del splitMain
            // 
            this._splitMain.Panel1.Controls.Add(this._grpFiltros);
            this._splitMain.Panel2.Controls.Add(this._splitDetail);
            this._splitDetail.Panel1.Controls.Add(this._dgvArticulos);
            this._splitDetail.Panel2.Controls.Add(this._grpDetalle);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1000, 620);
            this.Controls.Add(this._splitMain);
            this.Controls.Add(this._toolStrip);
            this.Controls.Add(this._statusStrip);
            this.Name = "MainForm";
            this.Text = "Gestión de Artículos";
            ((System.ComponentModel.ISupportInitialize)(this._splitMain)).EndInit();
            this._splitMain.Panel1.ResumeLayout(false);
            this._splitMain.Panel2.ResumeLayout(false);
            this._splitMain.ResumeLayout(false);
            this._grpFiltros.ResumeLayout(false);
            this._grpFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._splitDetail)).EndInit();
            this._splitDetail.Panel1.ResumeLayout(false);
            this._splitDetail.Panel2.ResumeLayout(false);
            this._splitDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._dgvArticulos)).EndInit();
            this._grpDetalle.ResumeLayout(false);
            this._statusStrip.ResumeLayout(false);
            this._statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
