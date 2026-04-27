using System.Collections.Generic;
using winform_app.Models;

namespace winform_app.Controllers
{
    public class MarcaController
    {
        public List<Marca> GetAll()
        {
            return Marca.GetAll();
        }
        public void Add(string descripcion)
        {
            var marca = new Marca { Descripcion = descripcion };
            marca.Add();
        }

        public bool ExisteConNombre(string nombre, int excludeId = 0)
        {
            return Marca.ExisteConNombre(nombre, excludeId);
        }

    }
}
