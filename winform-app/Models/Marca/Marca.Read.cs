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
                    });
                }
                datos.cerrarConexion();
            }
            return lista;
        }
    }
}
