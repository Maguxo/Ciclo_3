using System;
using System.Collections.Generic;
using System.Linq;
using HomePetCare.App.Dominio;

namespace HomePetCare.App.Persistencia
{
    public interface IRepositorioVisit
    {
       public IEnumerable<Visit> GetAllVisit();
        Visit AddVisit(Visit visit);
        Visit UpdateVisit(Visit visit);
        void DeleteVisit(int idVisit);
        Visit GetVisit(int idVisit);
        
    }
}