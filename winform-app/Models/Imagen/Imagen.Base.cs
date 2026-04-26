namespace winform_app.Models
{
    public partial class Imagen
    {
        public int Id { get; set; }
        public int IdArticulo { get; set; }
        public string ImagenUrl { get; set; }

        // Navegación
        public Articulo Articulo { get; set; }
    }
}
