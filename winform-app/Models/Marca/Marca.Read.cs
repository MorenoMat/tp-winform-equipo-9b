using System.Collections.Generic;
using winform_app.baseDeDatos;

namespace winform_app.Models
{
    public partial class Marca
    {
        public static List<Marca> GetAll()
        {
            var lista = new List<Marca>();
            using (var datos = new AccesoDatos())
            {
                datos.setearConsulta("SELECT Id, Descripcion FROM MARCAS ORDER BY Descripcion");
                datos.ejecutarLectura();
                var lector = datos.Lector;
                while (lector != null && lector.Read())
                {
                    lista.Add(new Marca
                    {
                        Id = lector.GetInt32(lector.GetOrdinal("Id")),
                        Descripcion = lector.GetString(lector.GetOrdinal("Descripcion"))
                    });  // es igual q poner marca m ;   m.Id = ...
                }
                datos.cerrarConexion();
            }
            return lista;
        }
        // excludeId: en modo edición se pasa el Id del artículo actual para no compararlo consigo mismo
        public static bool ExisteConNombre(string marca, int excludeId = 0)
        {
            const string sql = "SELECT COUNT(*) FROM MARCAS WHERE LOWER(Descripcion) = LOWER(@marca) AND Id <> @ExcludeId"; //mismo nombre y que  tenga distinto id

            using (var datos = new AccesoDatos())
            {
                datos.setearConsulta(sql);
                datos.setearParametro("@marca", marca);
                datos.setearParametro("@ExcludeId", excludeId);
                datos.ejecutarLectura();
                var lector = datos.Lector;
                var count = lector != null && lector.Read() ? lector.GetInt32(0) : 0;
                datos.cerrarConexion();
                return count > 0;
            }
        }

        public override string ToString() // sobreescribo ToString() xq si no me devuelve el nombre de la clase 
        {
            return Descripcion;
        }
    }
 }
