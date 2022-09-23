using System;
using System.Collections.Generic;
using System.Linq;
using HomePetCare.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace HomePetCare.App.Persistencia
{
    public class RepositorioVisit : IRepositorioVisit
    {
        
     
        private readonly AppContext _appContext;
        
        public RepositorioVisit(AppContext appContext)
        {
            _appContext = appContext;
        }

         Visit IRepositorioVisit.AddVisit(HomePetCare.App.Dominio.Visit visit)
        {
            var visAdicionado = _appContext.Visits.Add(visit);
            _appContext.SaveChanges();
            return visAdicionado.Entity;
        }

         void IRepositorioVisit.DeleteVisit(int idVisit)
         {
            var visEncontrado = _appContext.Visits.FirstOrDefault(d => d.Id == idVisit);
            if (visEncontrado == null)
                return;
            _appContext.Visits.Remove(visEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Visit> IRepositorioVisit.GetAllVisit()
        {
            return _appContext.Visits;
        }

        Visit IRepositorioVisit.GetVisit(int idVisit)
        {
            return _appContext.Visits.FirstOrDefault(c => c.Id  == idVisit);
        }

         Visit IRepositorioVisit.UpdateVisit(HomePetCare.App.Dominio.Visit visit)
        {
            var visEncontrado = _appContext.Visits.FirstOrDefault(c => c.Id == visit.Id);
            if (visEncontrado!=null)
            {
                 
                visEncontrado.Temperature = visit.Temperature;
                visEncontrado.Weight = visit.Weight;
                visEncontrado.Breath = visit.Breath;
                visEncontrado.RPM = visit.RPM;
                visEncontrado.Mood = visit.Mood;
                visEncontrado.Commentary = visit.Commentary;

                _appContext.SaveChanges();

            }
            return visEncontrado;
        }
    }
}