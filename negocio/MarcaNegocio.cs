using System.Collections.Generic;
using dominio;

namespace negocio
{
    public class MarcaNegocio
    {
        public List<Marca> listarTodos()
        {
            List<Marca> lista = new List<Marca>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Select Id, Descripcion From MARCAS");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Marca aux = new Marca();
                    aux.id = (int)datos.Lector["Id"];
                    aux.descripcion = (string)datos.Lector["Descripcion"];
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
            public void agregar(Marca marca)
            {
                AccesoDatos datos = new AccesoDatos();
                try
                {
                    datos.setearConsulta("Insert Into MARCAS (Descripcion) Values (@descripcion)");
                    datos.setearParametro("@descripcion", marca.descripcion);
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
