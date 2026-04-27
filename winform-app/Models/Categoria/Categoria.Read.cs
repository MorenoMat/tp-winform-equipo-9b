using System.Collections.Generic;
using winform_app.baseDeDatos;

namespace winform_app.Models
{
    public partial class Categoria
    {
        public static List<Categoria> GetAll()
        {
            var lista = new List<Categoria>();
            using (var datos = new AccesoDatos())
            {
                datos.setearConsulta("SELECT Id, Descripcion FROM CATEGORIAS ORDER BY Descripcion");
                datos.ejecutarLectura();
                var lector = datos.Lector;
                while (lector != null && lector.Read())
                {
                    lista.Add(new Categoria
                    {
                        Id = lector.GetInt32(lector.GetOrdinal("Id")),
                        Descripcion = lector.GetString(lector.GetOrdinal("Descripcion"))
                    });
                }
                datos.cerrarConexion();
            }
            return lista;
        }
        public static bool ExisteConNombre(string categoria, int excludeId = 0)
        {
            const string sql = "SELECT COUNT(*) FROM categorias WHERE LOWER(Descripcion) = LOWER(@categoria) AND Id <> @ExcludeId"; //mismo nombre y que  tenga distinto id
            // lower convierte a minúsculas para comparar 
            using (var datos = new AccesoDatos())
            {
                datos.setearConsulta(sql);
                datos.setearParametro("@categoria", categoria);
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
