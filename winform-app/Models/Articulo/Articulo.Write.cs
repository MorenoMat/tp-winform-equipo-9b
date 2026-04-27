using System;
using winform_app.baseDeDatos;

namespace winform_app.Models
{
    public partial class Articulo
    {
        public void Add()
        {
            const string sql = @"INSERT INTO ARTICULOS (Codigo, Nombre, Precio, Descripcion, IdMarca, IdCategoria)
                                  VALUES (@Codigo, @Nombre, @Precio, @Descripcion, @IdMarca, @IdCategoria)";

            using (var datos = new AccesoDatos())
            {
                datos.ejecutarAccion(sql);
                datos.setearParametro("@Codigo", Codigo);
                datos.setearParametro("@Nombre", Nombre);
                datos.setearParametro("@Precio", Precio);
                datos.setearParametro("@Descripcion", Descripcion);
                datos.setearParametro("@IdMarca", MarcaId);
                datos.setearParametro("@IdCategoria", CategoriaId);
                datos.ejecutarAccion();
                datos.cerrarConexion();
            }
        }
    }
}
