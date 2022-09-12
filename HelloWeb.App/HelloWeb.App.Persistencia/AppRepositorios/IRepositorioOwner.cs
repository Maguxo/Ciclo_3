using System;
using System.Collections.Generic;
using HelloWeb.App.Dominio;

namespace HelloWeb.App.Persistencia.AppRepositorios
{

    public interface IRepositorioOwner
    {
       
        public IEnumerable<Owner> GetAll();
        IEnumerable<Owner> GetInformaPorFiltro(string filtro);

        Owner GetInformaPorId(int infoId);
         
        Owner Update(Owner infoActualizado);
        Owner Add(Owner nuevoInfo);

        
    }
}