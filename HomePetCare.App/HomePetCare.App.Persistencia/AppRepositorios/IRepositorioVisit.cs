using System.Collections.Generic;
using HomePetCare.App.Dominio;

namespace HomePetCare.App.Persistencia
{
    public interface IRepositorioVisit
    {
        IEnumerable<Visit> GetAllVisit();
        Visit AddVisit(Visit visit);
        Visit UpdateVisit(Visit visit);
        void DeleteVisit(int idVisit);
        Visit GetVisit(int idVisit);

    }
}