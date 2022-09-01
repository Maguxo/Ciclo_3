using System.Collections.Generic;
using System.Linq;
using HomePetCare.App.Dominio;

namespace HomePetCare.App.Persistencia
{
    public class RepositorioVisit : IRepositorioVisit
    {
        
        /// <summary>
        /// Referencia ala contexto de paciente
        ///</summary>
        private readonly AppContext _appContext;
        ///<summary>
        ///Metodo constructor utiliza
        ///Inyección de dependencias para indicar el contexto a utilizar 
        ///</summary>
        ///<param name="appContext"></param>//
        public RepositorioVisit(AppContext appContext)
        {
            _appContext = appContext;
        }

         Visit IRepositorioVisit.AddVisit(Visit visit)
        {
            var visitAdicionado = _appContext.Visit.Add(visit);
            _appContext.SaveChanges();
            return visitAdicionado.Entity;
        }

         void IRepositorioVisit.DeleteVisit(int idVisit)
        {
            var visitEncontrado = _appContext.Visit.FirstOrDefault(v => v.Id == idVisit);
            if (visitEncontrado == null)
                return;
            _appContext.Visit.Remove(visitEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Visit> IRepositorioVisit.GetAllVisit()
        {
            return _appContext.Visit;
        }

        Visit IRepositorioVisit.GetVisit(int idVisit)
        {
            return _appContext.Visit.FirstOrDefault(v => v.Id == idVisit);
        }

         Visit IRepositorioVisit.UpdateVisit(Visit visit)
        {
            var visitEncontrado = _appContext.Visit.FirstOrDefault(v => v.Id == visit.Id);
            if (visitEncontrado!=null)
            {
                visitEncontrado.Temperature = visit.Temperature;
                visitEncontrado.Weight = visit.Weight;
                visitEncontrado.Breath = visit.Breath;
                visitEncontrado.RPM = visit.RPM;
                visitEncontrado.Mood = visit.Mood;
                visitEncontrado.VisitDate = visit.VisitDate;
                visitEncontrado.IdVet = visit.IdVet;
                visitEncontrado.IdDog = visit.IdDog;
                visitEncontrado.Commentary = visit.Commentary;
                _appContext.SaveChanges();

            }
            return visitEncontrado;
        }

       
    }
}