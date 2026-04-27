using System.Collections.Generic;
using winform_app.Models;

namespace winform_app.Controllers
{
    public class CategoriaController
    {
        public List<Categoria> GetAll()
        {
            return Categoria.GetAll();
        }
        public void Add(string descripcion)
        {
            var categoria = new Categoria { Descripcion = descripcion };
            categoria.Add();
        }

        public bool ExisteConNombre(string nombre, int excludeId = 0)
        {
            return Categoria.ExisteConNombre(nombre, excludeId);
        }
    }
}
