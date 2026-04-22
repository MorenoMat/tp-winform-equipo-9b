namespace winform_app.Forms.Articulo
{
    partial class ArticuloEditForm
    {
        private System.ComponentModel.IContainer components = null;

        // Labels
        private System.Windows.Forms.Label _lblCodigo;
        private System.Windows.Forms.Label _lblNombre;
        private System.Windows.Forms.Label _lblPrecio;
        private System.Windows.Forms.Label _lblMarca;
        private System.Windows.Forms.Label _lblCategoria;
        private System.Windows.Forms.Label _lblDescripcion;

        // Inputs
        private System.Windows.Forms.TextBox _txtCodigo;
        private System.Windows.Forms.TextBox _txtNombre;
        private System.Windows.Forms.TextBox _txtPrecio;
        private System.Windows.Forms.ComboBox _cmbMarca;
        private System.Windows.Forms.ComboBox _cmbCategoria;
        private System.Windows.Forms.TextBox _txtDescripcion;

        // Botones
        private System.Windows.Forms.Button _btnGuardar;
        private System.Windows.Forms.Button _btnCancelar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this._lblCodigo = new System.Windows.Forms.Label();
            this._txtCodigo = new System.Windows.Forms.TextBox();
            this._lblNombre = new System.Windows.Forms.Label();
            this._txtNombre = new System.Windows.Forms.TextBox();
            this._lblPrecio = new System.Windows.Forms.Label();
            this._txtPrecio = new System.Windows.Forms.TextBox();
            this._lblMarca = new System.Windows.Forms.Label();
            this._cmbMarca = new System.Windows.Forms.ComboBox();
            this._lblCategoria = new System.Windows.Forms.Label();
            this._cmbCategoria = new System.Windows.Forms.ComboBox();
            this._lblDescripcion = new System.Windows.Forms.Label();
            this._txtDescripcion = new System.Windows.Forms.TextBox();
            this._btnGuardar = new System.Windows.Forms.Button();
            this._btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _lblCodigo
            // 
            this._lblCodigo.Location = new System.Drawing.Point(12, 15);
            this._lblCodigo.Name = "_lblCodigo";
            this._lblCodigo.Size = new System.Drawing.Size(90, 16);
            this._lblCodigo.Text = "Código:";
            // 
            // _txtCodigo
            // 
            this._txtCodigo.Location = new System.Drawing.Point(110, 12);
            this._txtCodigo.Name = "_txtCodigo";
            this._txtCodigo.Size = new System.Drawing.Size(260, 20);
            this._txtCodigo.TabIndex = 0;
            // 
            // _lblNombre
            // 
            this._lblNombre.Location = new System.Drawing.Point(12, 48);
            this._lblNombre.Name = "_lblNombre";
            this._lblNombre.Size = new System.Drawing.Size(90, 16);
            this._lblNombre.Text = "Nombre:";
            // 
            // _txtNombre
            // 
            this._txtNombre.Location = new System.Drawing.Point(110, 45);
            this._txtNombre.Name = "_txtNombre";
            this._txtNombre.Size = new System.Drawing.Size(260, 20);
            this._txtNombre.TabIndex = 1;
            // 
            // _lblPrecio
            // 
            this._lblPrecio.Location = new System.Drawing.Point(12, 81);
            this._lblPrecio.Name = "_lblPrecio";
            this._lblPrecio.Size = new System.Drawing.Size(90, 16);
            this._lblPrecio.Text = "Precio:";
            // 
            // _txtPrecio
            // 
            this._txtPrecio.Location = new System.Drawing.Point(110, 78);
            this._txtPrecio.Name = "_txtPrecio";
            this._txtPrecio.Size = new System.Drawing.Size(120, 20);
            this._txtPrecio.TabIndex = 2;
            // 
            // _lblMarca
            // 
            this._lblMarca.Location = new System.Drawing.Point(12, 114);
            this._lblMarca.Name = "_lblMarca";
            this._lblMarca.Size = new System.Drawing.Size(90, 16);
            this._lblMarca.Text = "Marca:";
            // 
            // _cmbMarca
            // 
            this._cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbMarca.Location = new System.Drawing.Point(110, 111);
            this._cmbMarca.Name = "_cmbMarca";
            this._cmbMarca.Size = new System.Drawing.Size(260, 21);
            this._cmbMarca.TabIndex = 3;
            // 
            // _lblCategoria
            // 
            this._lblCategoria.Location = new System.Drawing.Point(12, 147);
            this._lblCategoria.Name = "_lblCategoria";
            this._lblCategoria.Size = new System.Drawing.Size(90, 16);
            this._lblCategoria.Text = "Categoría:";
            // 
            // _cmbCategoria
            // 
            this._cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbCategoria.Location = new System.Drawing.Point(110, 144);
            this._cmbCategoria.Name = "_cmbCategoria";
            this._cmbCategoria.Size = new System.Drawing.Size(260, 21);
            this._cmbCategoria.TabIndex = 4;
            // 
            // _lblDescripcion
            // 
            this._lblDescripcion.Location = new System.Drawing.Point(12, 180);
            this._lblDescripcion.Name = "_lblDescripcion";
            this._lblDescripcion.Size = new System.Drawing.Size(90, 16);
            this._lblDescripcion.Text = "Descripción:";
            // 
            // _txtDescripcion
            // 
            this._txtDescripcion.Location = new System.Drawing.Point(110, 177);
            this._txtDescripcion.Multiline = true;
            this._txtDescripcion.Name = "_txtDescripcion";
            this._txtDescripcion.Size = new System.Drawing.Size(260, 60);
            this._txtDescripcion.TabIndex = 5;
            // 
            // _btnGuardar
            // 
            this._btnGuardar.Location = new System.Drawing.Point(210, 255);
            this._btnGuardar.Name = "_btnGuardar";
            this._btnGuardar.Size = new System.Drawing.Size(75, 23);
            this._btnGuardar.TabIndex = 6;
            this._btnGuardar.Text = "Guardar";
            this._btnGuardar.UseVisualStyleBackColor = true;
            // 
            // _btnCancelar
            // 
            this._btnCancelar.Location = new System.Drawing.Point(295, 255);
            this._btnCancelar.Name = "_btnCancelar";
            this._btnCancelar.Size = new System.Drawing.Size(75, 23);
            this._btnCancelar.TabIndex = 7;
            this._btnCancelar.Text = "Cancelar";
            this._btnCancelar.UseVisualStyleBackColor = true;
            // 
            // ArticuloEditForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 295);
            this.Controls.Add(this._lblCodigo);
            this.Controls.Add(this._txtCodigo);
            this.Controls.Add(this._lblNombre);
            this.Controls.Add(this._txtNombre);
            this.Controls.Add(this._lblPrecio);
            this.Controls.Add(this._txtPrecio);
            this.Controls.Add(this._lblMarca);
            this.Controls.Add(this._cmbMarca);
            this.Controls.Add(this._lblCategoria);
            this.Controls.Add(this._cmbCategoria);
            this.Controls.Add(this._lblDescripcion);
            this.Controls.Add(this._txtDescripcion);
            this.Controls.Add(this._btnGuardar);
            this.Controls.Add(this._btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ArticuloEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Artículo";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
