using System;
using System.Collections.Generic;
using HelloWeb.App.Dominio;
using System.Linq;


namespace HelloWeb.App.Persistencia.AppRepositorios
{

    public class RepositorioConsultaMemoria : IRepositorioConsulta
    {

        List<Dog> saludos;

        public RepositorioConsultaMemoria()
        {
            saludos = new List<Dog>()
            {

                new Dog{Id=1,NameDog="Tarzan",Breed="San Bernardo"},
                new Dog{Id=2,NameDog="Rambo",Breed="Labrador"},
                new Dog{Id=3,NameDog="Maximo decimo meridio",Breed="Bobtail"}

            };
        }

        public IEnumerable<Dog> GetAll()
        {
            return saludos;
        }

        public IEnumerable<Dog> GetInformaPorFiltro(string filtro)
        {
            var saludos = GetAll();
            if (saludos != null)
            {
                return saludos;
            }
            return null;

        }

        public Dog GetInformaPorId(int infoId)
        {
            return saludos.SingleOrDefault(s => s.Id == infoId);
        }

        public Dog Update(Dog infoActualizado)
        {
            var saludo = saludos.SingleOrDefault(r => r.Id == infoActualizado.Id);
            if (saludo != null)
            {
                saludo.NameDog = infoActualizado.NameDog;
                saludo.Breed = infoActualizado.Breed;
                
            }
            return saludo;
        }
        public Dog Add(Dog nuevoInfo)
        {
            nuevoInfo.Id = saludos.Max(r => r.Id) +1;
            saludos.Add(nuevoInfo);
            return nuevoInfo;
        }
    
    }

}