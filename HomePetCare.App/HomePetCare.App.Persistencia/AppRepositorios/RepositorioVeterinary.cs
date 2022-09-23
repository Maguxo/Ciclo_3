using System;
using System.Collections.Generic;
using System.Linq;
using HomePetCare.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace HomePetCare.App.Persistencia
{
    public class RepositorioVeterinary : IRepositorioVeterinary
    {
        
     
        private readonly AppContext _appContext;
        
        public RepositorioVeterinary(AppContext appContext)
        {
            _appContext = appContext;
        }

         Veterinary IRepositorioVeterinary.AddVeterinary(HomePetCare.App.Dominio.Veterinary veterinary)
        {
            var vetAdicionado = _appContext.Veterinarys.Add(veterinary);
            _appContext.SaveChanges();
            return vetAdicionado.Entity;
        }

         void IRepositorioVeterinary.DeleteVeterinary(int idVeterinary)
         {
            var vetEncontrado = _appContext.Veterinarys.FirstOrDefault(d => d.Id == idVeterinary);
            if (vetEncontrado == null)
                return;
            _appContext.Veterinarys.Remove(vetEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Veterinary> IRepositorioVeterinary.GetAllVeterinary()
        {
            return _appContext.Veterinarys;
        }

        Veterinary IRepositorioVeterinary.GetVeterinary(int idVeterinary)
        {
            return _appContext.Veterinarys.FirstOrDefault(c => c.Id  == idVeterinary);
        }

         Veterinary IRepositorioVeterinary.UpdateVeterinary(HomePetCare.App.Dominio.Veterinary veterinary)
        {
            var vetEncontrado = _appContext.Veterinarys.FirstOrDefault(c => c.Id == veterinary.Id);
            if (vetEncontrado!=null)
            {
                 
                vetEncontrado.NameVet = veterinary.NameVet;
                vetEncontrado.LastNameVet = veterinary.LastNameVet;
                vetEncontrado.PhoneVet = veterinary.PhoneVet;
                vetEncontrado.ProfCard = veterinary.ProfCard;
                _appContext.SaveChanges();

            }
            return vetEncontrado;
        }
    }
}