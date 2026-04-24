using System;
using System.Collections.Generic;
using System.Windows.Forms;
using winform_app.baseDeDatos;
using winform_app.Models;

namespace winform_app.Controllers
{
    public class ArticuloController
    {
        public List<Articulo> GetAll()
        {
            return Articulo.GetAll();
        }

        public Articulo GetById(int id)
        {
            return Articulo.GetById(id);
        }

        public void Add(Articulo articulo)
        {
            articulo.Add();
        }

        public void Update(Articulo articulo)
        {
            articulo.Update();
        }

        public void Delete(int id)
        {
            var art = Articulo.GetById(id);
            if (art != null) art.Delete();
        }

       public List<Articulo> filtrar(string nombre, string marca, string categoria)
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos(); // clase q se comunica con SQL

            try

            {
                // consulta -> lo que se le pide a SQL
                //Nombre  y  Marca quedan vacios a no ser q pasen los ifs
               string consulta = "SELECT A.Id, A.Nombre,A.Codigo,A.Descripcion, M.Descripcion as Marca, C.Descripcion as Categoria, A.Precio " +
                          "FROM ARTICULOS A " +
                          "INNER JOIN MARCAS M ON A.IdMarca = M.Id " +
                          "INNER JOIN CATEGORIAS C ON A.IdCategoria = C.Id " +
                          "WHERE 1=1 "; // para que haya where, y puedan estar los AND despues

                if (!string.IsNullOrWhiteSpace(nombre))
                    consulta += " AND A.Nombre LIKE @nombre ";

                if (!string.IsNullOrWhiteSpace(marca))
                    consulta += " AND M.Descripcion = @marca ";

                if (!string.IsNullOrWhiteSpace(categoria))
                    consulta += " AND C.Descripcion = @categoria ";

                // --- PRIMERO SETEAMOS LA CONSULTA FINAL ---
                datos.setearConsulta(consulta);

                // --- DESPUÉS SETEAMOS LOS VALORES DE LOS @ ---
                if (!string.IsNullOrWhiteSpace(nombre))
                    datos.setearParametro("@nombre", "%" + nombre + "%");

                if (!string.IsNullOrWhiteSpace(marca))
                   datos.setearParametro("@marca", marca);

                if (!string.IsNullOrWhiteSpace(categoria))
                    datos.setearParametro("@categoria", categoria);


                datos.ejecutarLectura();






                while (datos.Lector.Read()) // recorre mientras sea true 1 por 1
                {
                    Articulo aux = new Articulo(); // guardo los datos en un obj articulo
                    {
                        aux.Id = (int)datos.Lector["Id"];
                        aux.Nombre = (string)datos.Lector["Nombre"];
                        aux.Codigo = (string)datos.Lector["Codigo"];
                        aux.Descripcion = (string)datos.Lector["Descripcion"];
                        aux.Marca = new Marca();
                        aux.Marca.Descripcion = (string)datos.Lector["Marca"]; //m.descripcion tiene as Marca
                        aux.Categoria = new Categoria();
                        aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                        aux.Precio = (decimal)datos.Lector["Precio"];
                    };

                    lista.Add(aux); // guardo obj articulo en la lista 
                }

               
                return lista;
               
            }

           catch(Exception ex)
           {
                throw ex;
           }
            // sin finally xq es IDisposable
        }
    }
}
