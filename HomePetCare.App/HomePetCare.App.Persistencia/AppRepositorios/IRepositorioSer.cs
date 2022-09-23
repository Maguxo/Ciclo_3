using System;
using System.Collections.Generic;
using System.Linq;
using HomePetCare.App.Dominio;

namespace HomePetCare.App.Persistencia
{
    public interface IRepositorioSer
    {
       public IEnumerable<Ser> GetAllSer();
        Ser AddSer(Ser ser);
        Ser UpdateSer(Ser ser);
        void DeleteSer(int idSer);
        Ser GetSer(int idSer);
        
    }
}