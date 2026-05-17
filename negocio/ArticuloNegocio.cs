using System.Collections.Generic;
using dominio;

namespace negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listarTodos()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Select A.Id, A.Codigo, A.Nombre, A.Descripcion, A.Precio, " +
                                     "M.Id IdMarca, M.Descripcion Marca, " +
                                     "C.Id IdCategoria, C.Descripcion Categoria " +
                                     "From ARTICULOS A, MARCAS M, CATEGORIAS C " +
                                     "Where M.Id = A.IdMarca " +
                                     "And C.Id = A.IdCategoria");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.id = (int)datos.Lector["Id"];
                    aux.codigo = (string)datos.Lector["Codigo"];
                    aux.nombre = (string)datos.Lector["Nombre"];
                    aux.descripcion = (string)datos.Lector["Descripcion"];
                    aux.precio = (decimal)datos.Lector["Precio"];
                    aux.marca = new Marca();
                    aux.marca.id = (int)datos.Lector["IdMarca"];
                    aux.marca.descripcion = (string)datos.Lector["Marca"];
                    aux.categoria = new Categoria();
                    aux.categoria.id = (int)datos.Lector["IdCategoria"];
                    aux.categoria.descripcion = (string)datos.Lector["Categoria"];
                    lista.Add(aux);
                }
                return lista;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public List<Articulo> filtrar(string nombre, int idCategoria, int idMarca)
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Select A.Id, A.Codigo, A.Nombre, A.Descripcion, A.Precio, " +
                                     "M.Id IdMarca, M.Descripcion Marca, " +
                                     "C.Id IdCategoria, C.Descripcion Categoria " +
                                     "From ARTICULOS A, MARCAS M, CATEGORIAS C " +
                                     "Where M.Id = A.IdMarca " +
                                     "And C.Id = A.IdCategoria " +
                                     "And A.Nombre Like @nombre " +
                                     "And (@idCategoria = 0 Or C.Id = @idCategoria) " +
                                     "And (@idMarca = 0 Or M.Id = @idMarca)");
                datos.setearParametro("@nombre", "%" + nombre + "%");
                datos.setearParametro("@idCategoria", idCategoria);
                datos.setearParametro("@idMarca", idMarca);
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.id = (int)datos.Lector["Id"];
                    aux.codigo = (string)datos.Lector["Codigo"];
                    aux.nombre = (string)datos.Lector["Nombre"];
                    aux.descripcion = (string)datos.Lector["Descripcion"];
                    aux.precio = (decimal)datos.Lector["Precio"];
                    aux.marca = new Marca();
                    aux.marca.id = (int)datos.Lector["IdMarca"];
                    aux.marca.descripcion = (string)datos.Lector["Marca"];
                    aux.categoria = new Categoria();
                    aux.categoria.id = (int)datos.Lector["IdCategoria"];
                    aux.categoria.descripcion = (string)datos.Lector["Categoria"];
                    lista.Add(aux);
                }
                return lista;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public int agregar(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Insert Into ARTICULOS (Codigo, Nombre, Descripcion, Precio, IdMarca, IdCategoria) " +
                                     "Values (@codigo, @nombre, @descripcion, @precio, @idMarca, @idCategoria); " +
                                     "Select SCOPE_IDENTITY()");
                datos.setearParametro("@codigo", articulo.codigo);
                datos.setearParametro("@nombre", articulo.nombre);
                datos.setearParametro("@descripcion", articulo.descripcion);
                datos.setearParametro("@precio", articulo.precio);
                datos.setearParametro("@idMarca", articulo.marca.id);
                datos.setearParametro("@idCategoria", articulo.categoria.id);
                return (int)(decimal)datos.ejecutarEscalar();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void actualizar(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Update ARTICULOS Set Codigo = @codigo, Nombre = @nombre, Descripcion = @descripcion, " +
                                     "Precio = @precio, IdMarca = @idMarca, IdCategoria = @idCategoria " +
                                     "Where Id = @id");
                datos.setearParametro("@codigo", articulo.codigo);
                datos.setearParametro("@nombre", articulo.nombre);
                datos.setearParametro("@descripcion", articulo.descripcion);
                datos.setearParametro("@precio", articulo.precio);
                datos.setearParametro("@idMarca", articulo.marca.id);
                datos.setearParametro("@idCategoria", articulo.categoria.id);
                datos.setearParametro("@id", articulo.id);
                datos.ejecutarAccion();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void borrar(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Delete From ARTICULOS Where Id = @id");
                datos.setearParametro("@id", id);
                datos.ejecutarAccion();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}

