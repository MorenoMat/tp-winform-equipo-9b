using System.Collections.Generic;
using winform_app.Models;

namespace winform_app.Controllers
{
    public class ImagenController
    {
        public List<Imagen> GetAll()
        {
            return Imagen.GetAll();
        }

        public List<Imagen> GetByArticuloId(int idArticulo)
        {
            return Imagen.GetByArticuloId(idArticulo);
        }

        public Imagen GetById(int id)
        {
            return Imagen.GetById(id);
        }

        public void Add(Imagen imagen)
        {
            imagen.Add();
        }

        public void Update(Imagen imagen)
        {
            imagen.Update();
        }

        public void Delete(int id)
        {
            var imagen = Imagen.GetById(id);
            if (imagen != null) imagen.Delete();
        }

        public void DeleteByArticuloId(int idArticulo)
        {
            var imagenes = Imagen.GetByArticuloId(idArticulo);
            foreach (var imagen in imagenes)
                imagen.Delete();
        }
    }
}
