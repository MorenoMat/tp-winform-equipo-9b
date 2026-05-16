using System;
using System.Collections.Generic;
using System.Windows.Forms;
using dominio;
using negocio;

namespace winform_app
{
    public partial class frmArticulos : Form
    {
        public frmArticulos()
        {
            InitializeComponent();
        }

        private void frmArticulos_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            List<Articulo> lista = negocio.listarTodos();

            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = lista;

            dgvArticulos.Columns["marca"].Visible = false;
            dgvArticulos.Columns["categoria"].Visible = false;

            dgvArticulos.Columns["id"].HeaderText = "ID";
            dgvArticulos.Columns["codigo"].HeaderText = "Código";
            dgvArticulos.Columns["nombre"].HeaderText = "Nombre";
            dgvArticulos.Columns["descripcion"].HeaderText = "Descripción";
            dgvArticulos.Columns["precio"].HeaderText = "Precio";
        }
    }
}
