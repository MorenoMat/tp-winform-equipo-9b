using System;
using System.Collections.Generic;
using System.Windows.Forms;
using dominio;
using negocio;

namespace winform_app
{
    public partial class nuevaMarca : Form
    {
        public nuevaMarca()
        {
            InitializeComponent();
        }

        private void nuevaMarca_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            MarcaNegocio negocio = new MarcaNegocio();
            List<Marca> lista = negocio.listarTodos();

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
            Marca marca = new Marca();
            marca.descripcion = textBox1.Text;

            MarcaNegocio negocio = new MarcaNegocio();
            negocio.agregar(marca);

            textBox1.Text = string.Empty;
            cargar();

            MessageBox.Show("marca Agregada correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
