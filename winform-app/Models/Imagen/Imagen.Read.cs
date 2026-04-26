using System.Collections.Generic;
using winform_app.baseDeDatos;

namespace winform_app.Models
{
    public partial class Imagen
    {
        public static List<Imagen> GetAll()
        {
            var lista = new List<Imagen>();
            const string sql = "SELECT Id, IdArticulo, ImagenUrl FROM IMAGENES ORDER BY Id";

            using (var datos = new AccesoDatos())
            {
                datos.setearConsulta(sql);
                datos.ejecutarLectura();
                var lector = datos.Lector;
                while (lector != null && lector.Read())
                {
                    lista.Add(new Imagen
                    {
                        Id = lector.GetInt32(lector.GetOrdinal("Id")),
                        IdArticulo = lector.GetInt32(lector.GetOrdinal("IdArticulo")),
                        ImagenUrl = lector.GetString(lector.GetOrdinal("ImagenUrl"))
                    });
                }
                datos.cerrarConexion();
            }
            return lista;
        }

        public static List<Imagen> GetByArticuloId(int idArticulo)
        {
            var lista = new List<Imagen>();
            const string sql = "SELECT Id, IdArticulo, ImagenUrl FROM IMAGENES WHERE IdArticulo = @IdArticulo ORDER BY Id";

            using (var datos = new AccesoDatos())
            {
                datos.setearConsulta(sql);
                datos.setearParametro("@IdArticulo", idArticulo);
                datos.ejecutarLectura();
                var lector = datos.Lector;
                while (lector != null && lector.Read())
                {
                    lista.Add(new Imagen
                    {
                        Id = lector.GetInt32(lector.GetOrdinal("Id")),
                        IdArticulo = lector.GetInt32(lector.GetOrdinal("IdArticulo")),
                        ImagenUrl = lector.GetString(lector.GetOrdinal("ImagenUrl"))
                    });
                }
                datos.cerrarConexion();
            }
            return lista;
        }

        public static Imagen GetById(int id)
        {
            Imagen imagen = null;
            const string sql = "SELECT Id, IdArticulo, ImagenUrl FROM IMAGENES WHERE Id = @Id";

            using (var datos = new AccesoDatos())
            {
                datos.setearConsulta(sql);
                datos.setearParametro("@Id", id);
                datos.ejecutarLectura();
                var lector = datos.Lector;
                if (lector != null && lector.Read())
                {
                    imagen = new Imagen
                    {
                        Id = lector.GetInt32(lector.GetOrdinal("Id")),
                        IdArticulo = lector.GetInt32(lector.GetOrdinal("IdArticulo")),
                        ImagenUrl = lector.GetString(lector.GetOrdinal("ImagenUrl"))
                    };
                }
                datos.cerrarConexion();
            }
            return imagen;
        }
    }
}
