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
            var sql = "iNSERT INTO  MARCAS(Descripcion=@Marca)";
            using (var datos = new AccesoDatos())
            {
                datos.ejecutarAccion(sql);
                datos.setearParametro("@Marca", Descripcion);
                datos.ejecutarLectura();
                datos.cerrarConexion();

            }


        }
    }
}
