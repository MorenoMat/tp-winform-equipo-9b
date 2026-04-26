using winform_app.baseDeDatos;

namespace winform_app.Models
{
    public partial class Imagen
    {
        public void Update()
        {
            const string sql = "UPDATE IMAGENES SET IdArticulo = @IdArticulo, ImagenUrl = @ImagenUrl WHERE Id = @Id";

            using (var datos = new AccesoDatos())
            {
                datos.setearConsulta(sql);
                datos.setearParametro("@Id", Id);
                datos.setearParametro("@IdArticulo", IdArticulo);
                datos.setearParametro("@ImagenUrl", ImagenUrl);
                datos.ejecutarAccion();
                datos.cerrarConexion();
            }
        }
    }
}
