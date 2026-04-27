namespace winform_app.Forms.Marca
{
    partial class MarcaNewForm
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
            this._lblMarcaNueva = new System.Windows.Forms.Label();
            this._btnGuardarMarcaNueva = new System.Windows.Forms.Button();
            this._btnCancelarMarcaNueva = new System.Windows.Forms.Button();
            this._dgvMarcas = new System.Windows.Forms.DataGridView();
            this.txtBNuevaMarca = new System.Windows.Forms.TextBox();
            this.Marcasexistentes = new System.Windows.Forms.Label();
            this.Marcas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._dgvMarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // _lblMarcaNueva
            // 
            this._lblMarcaNueva.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._lblMarcaNueva.Location = new System.Drawing.Point(59, 234);
            this._lblMarcaNueva.Name = "_lblMarcaNueva";
            this._lblMarcaNueva.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._lblMarcaNueva.Size = new System.Drawing.Size(103, 28);
            this._lblMarcaNueva.TabIndex = 14;
            this._lblMarcaNueva.Text = "Nueva Marca:";
            this._lblMarcaNueva.Click += new System.EventHandler(this._lblMarcaNueva_Click);
            // 
            // _btnGuardarMarcaNueva
            // 
            this._btnGuardarMarcaNueva.Location = new System.Drawing.Point(10, 290);
            this._btnGuardarMarcaNueva.Name = "_btnGuardarMarcaNueva";
            this._btnGuardarMarcaNueva.Size = new System.Drawing.Size(69, 23);
            this._btnGuardarMarcaNueva.TabIndex = 20;
            this._btnGuardarMarcaNueva.Text = "Guardar";
            this._btnGuardarMarcaNueva.UseVisualStyleBackColor = true;
            this._btnGuardarMarcaNueva.Click += new System.EventHandler(this._btnGuardarMarcaNueva_Click);
            // 
            // _btnCancelarMarcaNueva
            // 
            this._btnCancelarMarcaNueva.Location = new System.Drawing.Point(248, 290);
            this._btnCancelarMarcaNueva.Name = "_btnCancelarMarcaNueva";
            this._btnCancelarMarcaNueva.Size = new System.Drawing.Size(69, 23);
            this._btnCancelarMarcaNueva.TabIndex = 21;
            this._btnCancelarMarcaNueva.Text = "Cancelar";
            this._btnCancelarMarcaNueva.UseVisualStyleBackColor = true;
            this._btnCancelarMarcaNueva.Click += new System.EventHandler(this._btnCancelarMarcaNueva_Click);
            // 
            // _dgvMarcas
            // 
            this._dgvMarcas.AllowUserToAddRows = false;
            this._dgvMarcas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgvMarcas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Marcas});
            this._dgvMarcas.Location = new System.Drawing.Point(10, 21);
            this._dgvMarcas.MultiSelect = false;
            this._dgvMarcas.Name = "_dgvMarcas";
            this._dgvMarcas.ReadOnly = true;
            this._dgvMarcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._dgvMarcas.Size = new System.Drawing.Size(301, 210);
            this._dgvMarcas.TabIndex = 22;
            this._dgvMarcas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._dgvMarcas_CellContentClick);
            this._dgvMarcas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this._dgvMarcas_CellFormatting);
            // 
            // txtBNuevaMarca
            // 
            this.txtBNuevaMarca.Location = new System.Drawing.Point(62, 254);
            this.txtBNuevaMarca.Name = "txtBNuevaMarca";
            this.txtBNuevaMarca.Size = new System.Drawing.Size(231, 20);
            this.txtBNuevaMarca.TabIndex = 23;
            this.txtBNuevaMarca.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Marcasexistentes
            // 
            this.Marcasexistentes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Marcasexistentes.AutoSize = true;
            this.Marcasexistentes.Location = new System.Drawing.Point(17, 5);
            this.Marcasexistentes.Name = "Marcasexistentes";
            this.Marcasexistentes.Size = new System.Drawing.Size(93, 13);
            this.Marcasexistentes.TabIndex = 24;
            this.Marcasexistentes.Text = "Marcas Existentes";
            this.Marcasexistentes.Click += new System.EventHandler(this.label1_Click);
            // 
            // Marcas
            // 
            this.Marcas.DataPropertyName = "Marcas";
            this.Marcas.HeaderText = "MARCAS";
            this.Marcas.Name = "Marcas";
            this.Marcas.ReadOnly = true;
            // 
            // MarcaNewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 325);
            this.Controls.Add(this.Marcasexistentes);
            this.Controls.Add(this.txtBNuevaMarca);
            this.Controls.Add(this._dgvMarcas);
            this.Controls.Add(this._lblMarcaNueva);
            this.Controls.Add(this._btnGuardarMarcaNueva);
            this.Controls.Add(this._btnCancelarMarcaNueva);
            this.Name = "MarcaNewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MarcaNewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._dgvMarcas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label _lblMarcaNueva;
        private System.Windows.Forms.Button _btnGuardarMarcaNueva;
        private System.Windows.Forms.Button _btnCancelarMarcaNueva;
        private System.Windows.Forms.DataGridView _dgvMarcas;
        private System.Windows.Forms.TextBox txtBNuevaMarca;
        private System.Windows.Forms.Label Marcasexistentes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marcas;
    }
}