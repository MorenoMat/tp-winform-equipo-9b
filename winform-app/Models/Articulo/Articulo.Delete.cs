using System;
using winform_app.baseDeDatos;

namespace winform_app.Models
{
    public partial class Articulo
    {
        public void Delete()
        {
            const string sql = @"DELETE FROM ARTICULOS WHERE Id = @Id";

            using (var datos = new AccesoDatos())
            {
                datos.setearConsulta(sql);
                datos.setearParametro("@Id", Id);
                datos.ejecutarAccion();
                datos.cerrarConexion();
            }
        }
    }
}
