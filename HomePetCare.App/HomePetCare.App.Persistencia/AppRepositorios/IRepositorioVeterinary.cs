using System;
using System.Collections.Generic;
using System.Linq;
using HomePetCare.App.Dominio;

namespace HomePetCare.App.Persistencia
{
    public interface IRepositorioVeterinary
    {
       public IEnumerable<Veterinary> GetAllVeterinary();
        Veterinary AddVeterinary(Veterinary veterinary);
        Veterinary UpdateVeterinary(Veterinary veterinary);
        void DeleteVeterinary(int idVeterinary);
        Veterinary GetVeterinary(int idVeterinary);
        
    }
}