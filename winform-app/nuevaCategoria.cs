using System;
using System.Collections.Generic;
using System.Windows.Forms;
using dominio;
using negocio;

namespace winform_app
{
    public partial class nuevaCategoria : Form
    {
        public nuevaCategoria()
        {
            InitializeComponent();
        }

        private void nuevaCategoria_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            List<Categoria> lista = negocio.listarTodos();

            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = lista;
            dgvArticulos.Columns["id"].Visible = false;

            dgvArticulos.Columns["id"].HeaderText = "ID";
            dgvArticulos.Columns["descripcion"].HeaderText = "Descripción";
        }

        private void dgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();
            categoria.descripcion = textBox1.Text;

            CategoriaNegocio negocio = new CategoriaNegocio();
            negocio.agregar(categoria);

            textBox1.Text = string.Empty;
            cargar();

            MessageBox.Show("Categoría agregada correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
