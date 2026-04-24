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
        public override string ToString() // sobreescribo ToString() xq si no me devuelve el nombre de la clase 
        {
            return Descripcion;
        }


    }
}
