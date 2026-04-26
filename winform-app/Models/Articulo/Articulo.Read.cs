using System;
using System.Collections.Generic;
using winform_app.baseDeDatos;

namespace winform_app.Models
{
    public partial class Articulo
    {
        public static List<Articulo> GetAll()
        {
            var lista = new List<Articulo>();
            const string sql = @"SELECT a.Id, a.Codigo, a.Nombre, a.Precio, a.Descripcion, a.IdMarca, a.IdCategoria,
                                m.Id AS MarcaId, m.Descripcion AS MarcaDescripcion,
                                c.Id AS CategoriaId, c.Descripcion AS CategoriaDescripcion
                         FROM ARTICULOS a
                         LEFT JOIN MARCAS m ON a.IdMarca = m.Id
                         LEFT JOIN CATEGORIAS c ON a.IdCategoria = c.Id";

            using (var datos = new AccesoDatos())
            {
                datos.setearConsulta(sql);
                datos.ejecutarLectura();
                var lector = datos.Lector;
                while (lector != null && lector.Read())
                {
                    var art = new Articulo();
                    int idx;
                    idx = lector.GetOrdinal("Id");
                    art.Id = lector.IsDBNull(idx) ? 0 : lector.GetInt32(idx);
                    idx = lector.GetOrdinal("Codigo");
                    art.Codigo = lector.IsDBNull(idx) ? null : lector.GetString(idx);
                    idx = lector.GetOrdinal("Nombre");
                    art.Nombre = lector.IsDBNull(idx) ? null : lector.GetString(idx);
                    idx = lector.GetOrdinal("Precio");
                    art.Precio = lector.IsDBNull(idx) ? 0 : lector.GetDecimal(idx);
                    idx = lector.GetOrdinal("Descripcion");
                    art.Descripcion = lector.IsDBNull(idx) ? null : lector.GetString(idx);
                    idx = lector.GetOrdinal("IdMarca");
                    art.MarcaId = lector.IsDBNull(idx) ? 0 : lector.GetInt32(idx);
                    idx = lector.GetOrdinal("IdCategoria");
                    art.CategoriaId = lector.IsDBNull(idx) ? 0 : lector.GetInt32(idx);

                    idx = lector.GetOrdinal("MarcaId");
                    if (!lector.IsDBNull(idx))
                    {
                        var marca = new Marca();
                        marca.Id = lector.GetInt32(idx);
                        var idxDesc = lector.GetOrdinal("MarcaDescripcion");
                        marca.Descripcion = lector.IsDBNull(idxDesc) ? null : lector.GetString(idxDesc);
                        art.Marca = marca;
                    }

                    idx = lector.GetOrdinal("CategoriaId");
                    if (!lector.IsDBNull(idx))
                    {
                        var categoria = new Categoria();
                        categoria.Id = lector.GetInt32(idx);
                        var idxDesc = lector.GetOrdinal("CategoriaDescripcion");
                        categoria.Descripcion = lector.IsDBNull(idxDesc) ? null : lector.GetString(idxDesc);
                        art.Categoria = categoria;
                    }

                    lista.Add(art);
                }

                datos.cerrarConexion();
            }

            return lista;
        }

        public static Articulo GetById(int id)
        {
            const string sql = @"SELECT a.Id, a.Codigo, a.Nombre, a.Precio, a.Descripcion, a.IdMarca, a.IdCategoria,
                                        m.Id AS MarcaId, m.Descripcion AS MarcaDescripcion,
                                        c.Id AS CategoriaId, c.Descripcion AS CategoriaDescripcion
                                 FROM ARTICULOS a
                                 LEFT JOIN MARCAS m ON a.IdMarca = m.Id
                                 LEFT JOIN CATEGORIAS c ON a.IdCategoria = c.Id
                                 WHERE a.Id = @Id";

            using (var datos = new AccesoDatos())
            {
                datos.setearConsulta(sql);
                datos.setearParametro("@Id", id);
                datos.ejecutarLectura();

                var lector = datos.Lector;
                Articulo art = null;
                if (lector != null && lector.Read())
                {
                    art = new Articulo();
                    int idx;
                    idx = lector.GetOrdinal("Id");
                    art.Id = lector.IsDBNull(idx) ? 0 : lector.GetInt32(idx);
                    idx = lector.GetOrdinal("Codigo");
                    art.Codigo = lector.IsDBNull(idx) ? null : lector.GetString(idx);
                    idx = lector.GetOrdinal("Nombre");
                    art.Nombre = lector.IsDBNull(idx) ? null : lector.GetString(idx);
                    idx = lector.GetOrdinal("Precio");
                    art.Precio = lector.IsDBNull(idx) ? 0 : lector.GetDecimal(idx);
                    idx = lector.GetOrdinal("Descripcion");
                    art.Descripcion = lector.IsDBNull(idx) ? null : lector.GetString(idx);
                    idx = lector.GetOrdinal("IdMarca");
                    art.MarcaId = lector.IsDBNull(idx) ? 0 : lector.GetInt32(idx);
                    idx = lector.GetOrdinal("IdCategoria");
                    art.CategoriaId = lector.IsDBNull(idx) ? 0 : lector.GetInt32(idx);

                    // Marca
                    idx = lector.GetOrdinal("MarcaId");
                    if (!lector.IsDBNull(idx))
                    {
                        var marca = new Marca();
                        marca.Id = lector.GetInt32(idx);
                        var idxDesc = lector.GetOrdinal("MarcaDescripcion");
                        marca.Descripcion = lector.IsDBNull(idxDesc) ? null : lector.GetString(idxDesc);
                        art.Marca = marca;
                    }

                    // Categoria
                    idx = lector.GetOrdinal("CategoriaId");
                    if (!lector.IsDBNull(idx))
                    {
                        var categoria = new Categoria();
                        categoria.Id = lector.GetInt32(idx);
                        var idxDesc = lector.GetOrdinal("CategoriaDescripcion");
                        categoria.Descripcion = lector.IsDBNull(idxDesc) ? null : lector.GetString(idxDesc);
                        art.Categoria = categoria;
                    }
                }

                datos.cerrarConexion();
                return art;
            }
        }

        // excludeId: en modo edición se pasa el Id del artículo actual para no compararlo consigo mismo
        public static bool ExisteConNombre(string nombre, int excludeId = 0)
        {
            const string sql = "SELECT COUNT(*) FROM ARTICULOS WHERE LOWER(Nombre) = LOWER(@Nombre) AND Id <> @ExcludeId";

            using (var datos = new AccesoDatos())
            {
                datos.setearConsulta(sql);
                datos.setearParametro("@Nombre", nombre);
                datos.setearParametro("@ExcludeId", excludeId);
                datos.ejecutarLectura();
                var lector = datos.Lector;
                var count = lector != null && lector.Read() ? lector.GetInt32(0) : 0;
                datos.cerrarConexion();
                return count > 0;
            }
        }
    }
}
