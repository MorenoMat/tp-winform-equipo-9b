using System.ComponentModel;

namespace winform_app.Forms.Categoria
{
    partial class CategoriaNewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Categoriasexistentes = new System.Windows.Forms.Label();
            this.txtBNuevaCategoria = new System.Windows.Forms.TextBox();
            this._dgvCategorias = new System.Windows.Forms.DataGridView();
            this._lblCategoriaNueva = new System.Windows.Forms.Label();
            this._btnGuardarCategoriaNueva = new System.Windows.Forms.Button();
            this._btnCancelarCategoriaNueva = new System.Windows.Forms.Button();
            this.Categorias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._dgvCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // Categoriasexistentes
            // 
            this.Categoriasexistentes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Categoriasexistentes.AutoSize = true;
            this.Categoriasexistentes.Location = new System.Drawing.Point(9, 9);
            this.Categoriasexistentes.Name = "Categoriasexistentes";
            this.Categoriasexistentes.Size = new System.Drawing.Size(108, 13);
            this.Categoriasexistentes.TabIndex = 30;
            this.Categoriasexistentes.Text = "Categorias Existentes";
            this.Categoriasexistentes.Click += new System.EventHandler(this.Categoriasexistentes_Click);
            // 
            // txtBNuevaCategoria
            // 
            this.txtBNuevaCategoria.Location = new System.Drawing.Point(64, 258);
            this.txtBNuevaCategoria.Name = "txtBNuevaCategoria";
            this.txtBNuevaCategoria.Size = new System.Drawing.Size(231, 20);
            this.txtBNuevaCategoria.TabIndex = 29;
            this.txtBNuevaCategoria.TextChanged += new System.EventHandler(this.txtBNuevaCategoria_TextChanged);
            // 
            // _dgvCategorias
            // 
            this._dgvCategorias.AllowUserToAddRows = false;
            this._dgvCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgvCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Categorias});
            this._dgvCategorias.Location = new System.Drawing.Point(12, 25);
            this._dgvCategorias.MultiSelect = false;
            this._dgvCategorias.Name = "_dgvCategorias";
            this._dgvCategorias.ReadOnly = true;
            this._dgvCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._dgvCategorias.Size = new System.Drawing.Size(301, 210);
            this._dgvCategorias.TabIndex = 28;
            this._dgvCategorias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._dgvCategorias_CellContentClick);
            // 
            // _lblCategoriaNueva
            // 
            this._lblCategoriaNueva.Location = new System.Drawing.Point(61, 238);
            this._lblCategoriaNueva.Name = "_lblCategoriaNueva";
            this._lblCategoriaNueva.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._lblCategoriaNueva.Size = new System.Drawing.Size(111, 17);
            this._lblCategoriaNueva.TabIndex = 25;
            this._lblCategoriaNueva.Text = "Nueva Categoria:";
            this._lblCategoriaNueva.Click += new System.EventHandler(this._lblCategoriaNueva_Click);
            // 
            // _btnGuardarCategoriaNueva
            // 
            this._btnGuardarCategoriaNueva.Location = new System.Drawing.Point(12, 294);
            this._btnGuardarCategoriaNueva.Name = "_btnGuardarCategoriaNueva";
            this._btnGuardarCategoriaNueva.Size = new System.Drawing.Size(69, 23);
            this._btnGuardarCategoriaNueva.TabIndex = 26;
            this._btnGuardarCategoriaNueva.Text = "Guardar";
            this._btnGuardarCategoriaNueva.UseVisualStyleBackColor = true;
            this._btnGuardarCategoriaNueva.Click += new System.EventHandler(this._btnGuardarCategoriaNueva_Click);
            // 
            // _btnCancelarCategoriaNueva
            // 
            this._btnCancelarCategoriaNueva.Location = new System.Drawing.Point(250, 294);
            this._btnCancelarCategoriaNueva.Name = "_btnCancelarCategoriaNueva";
            this._btnCancelarCategoriaNueva.Size = new System.Drawing.Size(69, 23);
            this._btnCancelarCategoriaNueva.TabIndex = 27;
            this._btnCancelarCategoriaNueva.Text = "Cancelar";
            this._btnCancelarCategoriaNueva.UseVisualStyleBackColor = true;
            this._btnCancelarCategoriaNueva.Click += new System.EventHandler(this._btnCancelarCategoriaNueva_Click);
            // 
            // Categorias
            // 
            this.Categorias.HeaderText = "Categorias";
            this.Categorias.Name = "Categorias";
            this.Categorias.ReadOnly = true;
            // 
            // CategoriaNewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 327);
            this.Controls.Add(this.Categoriasexistentes);
            this.Controls.Add(this.txtBNuevaCategoria);
            this.Controls.Add(this._dgvCategorias);
            this.Controls.Add(this._lblCategoriaNueva);
            this.Controls.Add(this._btnGuardarCategoriaNueva);
            this.Controls.Add(this._btnCancelarCategoriaNueva);
            this.Name = "CategoriaNewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categorias";
            this.Load += new System.EventHandler(this.CategoriaNewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._dgvCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Categoriasexistentes;
        private System.Windows.Forms.TextBox txtBNuevaCategoria;
        private System.Windows.Forms.DataGridView _dgvCategorias;
        private System.Windows.Forms.Label _lblCategoriaNueva;
        private System.Windows.Forms.Button _btnGuardarCategoriaNueva;
        private System.Windows.Forms.Button _btnCancelarCategoriaNueva;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categorias;
        //  private ISupportInitialize _dgvCategorias;
    }
}