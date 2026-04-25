using System;
using winform_app.baseDeDatos;

namespace winform_app.Models
{
    public partial class Articulo
    {
        public void Update()
        {
            const string sql = @"UPDATE ARTICULOS SET Codigo = @Codigo, Nombre = @Nombre, Precio = @Precio, Descripcion = @Descripcion, IdMarca = @IdMarca, IdCategoria = @IdCategoria WHERE Id = @Id";

            using (var datos = new AccesoDatos())
            {
                datos.setearConsulta(sql);
                datos.setearParametro("@Codigo", Codigo);
                datos.setearParametro("@Nombre", Nombre);
                datos.setearParametro("@Precio", Precio);
                datos.setearParametro("@Descripcion", Descripcion);
                datos.setearParametro("@IdMarca", MarcaId);
                datos.setearParametro("@IdCategoria", CategoriaId);
                datos.setearParametro("@Id", Id);
                datos.ejecutarAccion();
                datos.cerrarConexion();
            }
        }
    }
}
