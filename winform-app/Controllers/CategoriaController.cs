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
    }
}
