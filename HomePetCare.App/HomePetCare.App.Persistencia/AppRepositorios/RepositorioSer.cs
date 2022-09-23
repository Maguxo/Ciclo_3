using System;
using System.Collections.Generic;
using System.Linq;
using HomePetCare.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace HomePetCare.App.Persistencia
{
    public class RepositorioSer : IRepositorioSer
    {
        
     
        private readonly AppContext _appContext;
        
        public RepositorioSer(AppContext appContext)
        {
            _appContext = appContext;
        }

         Ser IRepositorioSer.AddSer(Ser ser)
        {
            var serAdicionado = _appContext.seres.Add(ser);
            _appContext.SaveChanges();
            return serAdicionado.Entity;
        }

         void IRepositorioSer.DeleteSer(int idSer)
         {
            var serEncontrado = _appContext.seres.FirstOrDefault(d => d.Id == idSer);
            if (serEncontrado == null)
                return;
            _appContext.seres.Remove(serEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Ser> IRepositorioSer.GetAllSer()
        {
            return _appContext.seres;
        }

        Ser IRepositorioSer.GetSer(int idSer)
        {
            return _appContext.seres.FirstOrDefault(c => c.Id  == idSer);
        }

         Ser IRepositorioSer.UpdateSer(HomePetCare.App.Dominio.Ser ser)
        {
            var serEncontrado = _appContext.seres.FirstOrDefault(c => c.Id == ser.Id);
            if (serEncontrado!=null)
            {
                 
                serEncontrado.Name = ser.Name;
                serEncontrado.LastName = ser.LastName;
                serEncontrado.Telephone = ser.Telephone;
                
                _appContext.SaveChanges();

            }
            return serEncontrado;
        }
    }
}