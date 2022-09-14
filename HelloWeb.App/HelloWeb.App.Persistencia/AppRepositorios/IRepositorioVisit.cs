using System;
using System.Collections.Generic;
using HelloWeb.App.Dominio;

namespace HelloWeb.App.Persistencia.AppRepositorios
{

    public interface IRepositorioVisit
    {
        public IEnumerable<Visit> GetAll();
        IEnumerable<Visit> GetInformaPorFiltro(string filtro);

        Visit GetInformaPorId(int infoId);
         
        Visit Update(Visit infoActualizado);
        Visit Add(Visit nuevoInfo);

       
    }
}