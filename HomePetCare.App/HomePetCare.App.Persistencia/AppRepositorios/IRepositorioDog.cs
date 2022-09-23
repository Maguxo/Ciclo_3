using System;
using System.Collections.Generic;
using System.Linq;
using HomePetCare.App.Dominio;

namespace HomePetCare.App.Persistencia
{
    public interface IRepositorioDog
    {
       public IEnumerable<Dog> GetAllDog();
        Dog AddDog(Dog dog);
        Dog UpdateDog(Dog dog);
        void DeleteDog(int idDog);
        Dog GetDog(int idDog);
        Veterinary AsignaVeterinario(int idDog, int IdVet);
        Veterinary  AddVeterinary(Veterinary verterinary);
        IEnumerable<Dog> GetDogMasculinos();
        IEnumerable<Dog> GetDogCorazon();

    }
}