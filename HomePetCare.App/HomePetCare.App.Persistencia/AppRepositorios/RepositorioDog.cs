using System;
using System.Collections.Generic;
using System.Linq;
using HomePetCare.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace HomePetCare.App.Persistencia
{
    public class RepositorioDog : IRepositorioDog
    {
        
     
        private readonly AppContext _appContext;
        
        public RepositorioDog(AppContext appContext)
        {
            _appContext = appContext;
        }

         Dog IRepositorioDog.AddDog(Dog dog)
        {
            var dogAdicionado = _appContext.Dogs.Add(dog);
            _appContext.SaveChanges();
            return dogAdicionado.Entity;
        }

         void IRepositorioDog.DeleteDog(int idDog)
         {
            var dogEncontrado = _appContext.Dogs.FirstOrDefault(d => d.Id == idDog);
            if (dogEncontrado == null)
                return;
            _appContext.Dogs.Remove(dogEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Dog> IRepositorioDog.GetAllDog()
        {
            return _appContext.Dogs;
        }

        Dog IRepositorioDog.GetDog(int idDog)
        {
            return _appContext.Dogs.FirstOrDefault(c => c.Id  == idDog);
        }

         Dog IRepositorioDog.UpdateDog(HomePetCare.App.Dominio.Dog dog)
        {
            var dogEncontrado = _appContext.Dogs.FirstOrDefault(c => c.Id == dog.Id);
            if (dogEncontrado!=null)
            {
                 
                dogEncontrado.NameVDog = dog.NameVDog;
                dogEncontrado.Breed = dog.Breed;
                dogEncontrado.FechaNacimiento= dog.FechaNacimiento;
                dogEncontrado.Color=dog.Color;
                dogEncontrado.veterinario = dog.veterinario;
                dogEncontrado.visita= dog.visita;
                dogEncontrado.dueño= dog.dueño;
                //dogEncontrado.Estado = dog.Estado;
                 
                
                
                _appContext.SaveChanges();

            }
            return dogEncontrado;
        }

             Veterinary IRepositorioDog.AsignaVeterinario(int idDog, int IdVet)
        {
            var perroEncontrado = _appContext.Dogs.FirstOrDefault(p => p.Id == idDog);
            if (perroEncontrado != null)
            {
                var veterinarioEncontrado = _appContext.Veterinarys.FirstOrDefault(m => m.Id == IdVet);
                if (veterinarioEncontrado != null)
                {
                    perroEncontrado.veterinario =veterinarioEncontrado;
                    _appContext.SaveChanges();
                }
                return veterinarioEncontrado;
            }
            return null;
        }
             Veterinary IRepositorioDog.AddVeterinary(Veterinary verterinary)
        {
            var vetAdicionado = _appContext.Veterinarys.Add(verterinary);
            _appContext.SaveChanges();
            return vetAdicionado.Entity;
        }
       
       IEnumerable<Dog> IRepositorioDog.GetDogMasculinos()
       {
        return  _appContext.Dogs.Where(p => p.Color == "Negro").ToList();
       }

       IEnumerable<Dog> IRepositorioDog.GetDogCorazon()
       {
        return _appContext.Dogs
        .Where(p => p.Estado.Any(s=> TipoVital.FrecuenciaRespiratoria== s.Signo && s.Valor >= 90))
        .ToList();
       }
    }
}