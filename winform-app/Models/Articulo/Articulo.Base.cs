using System;

namespace winform_app.Models
{
    public partial class Articulo
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int MarcaId { get; set; }
        public int CategoriaId { get; set; }

        // Navegación
        public Marca Marca { get; set; }
        public Categoria Categoria { get; set; }

        // Propiedades calculadas para binding en DataGridView
        public string MarcaNombre => Marca?.Descripcion ?? string.Empty;
        public string CategoriaNombre => Categoria?.Descripcion ?? string.Empty;
    }
}
