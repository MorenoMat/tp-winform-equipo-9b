using System;
using System.Collections.Generic;
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
    }
}
