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
    }
}
