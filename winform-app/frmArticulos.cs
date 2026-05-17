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
            traerTodosLosArticulos();
            cargar_combo_categoria();
            cargar_combo_marca();
        }

        private void traerTodosLosArticulos()
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            List<Articulo> lista = articuloNegocio.listarTodos();

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

        private void cargar_combo_categoria()
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            List<Categoria> categorias = categoriaNegocio.listarTodos();
            categorias.Insert(0, new Categoria { id = 0, descripcion = "Todas" });
            comboBox1.DataSource = categorias;
            comboBox1.DisplayMember = "descripcion";
            comboBox1.ValueMember = "id";
        }

        private void cargar_combo_marca()
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            List<Marca> marcas = marcaNegocio.listarTodos();
            marcas.Insert(0, new Marca { id = 0, descripcion = "Todas" });
            comboBox2.DataSource = marcas;
            comboBox2.DisplayMember = "descripcion";
            comboBox2.ValueMember = "id";
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void TxtFiltro_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            List<Articulo> lista = articuloNegocio.filtrar(txtFiltro.Text, (int)comboBox1.SelectedValue, (int)comboBox2.SelectedValue);

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

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
