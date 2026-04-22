namespace winform_app.Forms.Articulo
{
    partial class ArticuloDeleteForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label _lblMensaje;
        private System.Windows.Forms.Label _lblNombreArticulo;
        private System.Windows.Forms.Button _btnConfirmar;
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
            this._lblMensaje = new System.Windows.Forms.Label();
            this._lblNombreArticulo = new System.Windows.Forms.Label();
            this._btnConfirmar = new System.Windows.Forms.Button();
            this._btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _lblMensaje
            // 
            this._lblMensaje.Location = new System.Drawing.Point(12, 20);
            this._lblMensaje.Name = "_lblMensaje";
            this._lblMensaje.Size = new System.Drawing.Size(360, 20);
            this._lblMensaje.Text = "¿Estás seguro que querés eliminar el siguiente artículo?";
            // 
            // _lblNombreArticulo
            // 
            this._lblNombreArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this._lblNombreArticulo.Location = new System.Drawing.Point(12, 50);
            this._lblNombreArticulo.Name = "_lblNombreArticulo";
            this._lblNombreArticulo.Size = new System.Drawing.Size(360, 20);
            this._lblNombreArticulo.Text = "-";
            this._lblNombreArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _btnConfirmar
            // 
            this._btnConfirmar.Location = new System.Drawing.Point(120, 90);
            this._btnConfirmar.Name = "_btnConfirmar";
            this._btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this._btnConfirmar.TabIndex = 0;
            this._btnConfirmar.Text = "Confirmar";
            this._btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // _btnCancelar
            // 
            this._btnCancelar.Location = new System.Drawing.Point(205, 90);
            this._btnCancelar.Name = "_btnCancelar";
            this._btnCancelar.Size = new System.Drawing.Size(75, 23);
            this._btnCancelar.TabIndex = 1;
            this._btnCancelar.Text = "Cancelar";
            this._btnCancelar.UseVisualStyleBackColor = true;
            // 
            // ArticuloDeleteForm
            // 
            this.ClientSize = new System.Drawing.Size(384, 131);
            this.Controls.Add(this._lblMensaje);
            this.Controls.Add(this._lblNombreArticulo);
            this.Controls.Add(this._btnConfirmar);
            this.Controls.Add(this._btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ArticuloDeleteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Eliminar artículo";
            this.ResumeLayout(false);
        }
    }
}
