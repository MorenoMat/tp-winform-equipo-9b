using System;
using winform_app.baseDeDatos;

namespace winform_app.Models
{
    public partial class Categoria
    {
        // Inserciones / creación de Categoria (Add)
        // Implementar en caso de ser necesario.
        internal void Add()
        {
            var sql = "INSERT INTO CATEGORIAS (Descripcion) VALUES (@Categoria)";
            using (var datos = new AccesoDatos())
            {
                datos.setearParametro("@Categoria", Descripcion);
                datos.ejecutarAccion(sql);
                datos.ejecutarLectura();
                datos.cerrarConexion();
            }
    }
}}
