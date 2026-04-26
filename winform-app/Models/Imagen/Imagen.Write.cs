using winform_app.baseDeDatos;

namespace winform_app.Models
{
    public partial class Imagen
    {
        public void Add()
        {
            const string sql = "INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (@IdArticulo, @ImagenUrl)";

            using (var datos = new AccesoDatos())
            {
                datos.setearConsulta(sql);
                datos.setearParametro("@IdArticulo", IdArticulo);
                datos.setearParametro("@ImagenUrl", ImagenUrl);
                datos.ejecutarAccion();
                datos.cerrarConexion();
            }
        }
    }
}
