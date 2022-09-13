using System;
using System.Collections.Generic;
using HelloWeb.App.Dominio;

namespace HelloWeb.App.Persistencia.AppRepositorios
{

    public interface IRepositorioVeterinary
    {
        public IEnumerable<Veterinary> GetAll();
        IEnumerable<Veterinary> GetInformaPorFiltro(string filtro);

        Veterinary GetInformaPorId(int infoId);
         
        Veterinary Update(Veterinary infoActualizado);
        Veterinary Add(Veterinary nuevoInfo);

       
    }
}