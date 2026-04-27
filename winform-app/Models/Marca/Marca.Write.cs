using System.Collections.Generic;
using winform_app.baseDeDatos;

namespace winform_app.Models
{
    public partial class Marca
    {
        // Inserciones / creación de Marca (Add)
        // Implementar en caso de ser necesario.
        public void Add()
        {
            var sql = "INSERT INTO MARCAS (Descripcion) VALUES (@Marca)";
            using (var datos = new AccesoDatos())
            {
                datos.setearParametro("@Marca", Descripcion);
                datos.setearConsulta(sql);
                datos.ejecutarLectura();
                datos.cerrarConexion();

            }


        }
    }
}
