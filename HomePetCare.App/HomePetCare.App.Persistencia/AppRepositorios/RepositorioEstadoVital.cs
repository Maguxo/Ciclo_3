using System;
using System.Collections.Generic;
using System.Linq;
using HomePetCare.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace HomePetCare.App.Persistencia
{
    public class RepositorioEstadoVital : IRepositorioEstadoVital
    {


        private readonly AppContext _appContext;

        public RepositorioEstadoVital(AppContext appContext)
        {
            _appContext = appContext;
        }

        EstadoVital IRepositorioEstadoVital.AddEstadoVital(EstadoVital estadoVital)
        {
            var estadoVitalAdicionado = _appContext.EstadoVitales.Add(estadoVital);
            _appContext.SaveChanges();
            return estadoVitalAdicionado.Entity;
        }

        void IRepositorioEstadoVital.DeleteEstadoVital(int idEstadoVital)
        {
            var estadoVitalEncontrado = _appContext.EstadoVitales.FirstOrDefault(d => d.Id == idEstadoVital);
            if (estadoVitalEncontrado == null)
                return;
            _appContext.EstadoVitales.Remove(estadoVitalEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<EstadoVital> IRepositorioEstadoVital.GetAllEstadoVital()
        {
            return _appContext.EstadoVitales;
        }

        EstadoVital IRepositorioEstadoVital.GetEstadoVital(int idEstadoVital)
        {
            return _appContext.EstadoVitales.FirstOrDefault(c => c.Id == idEstadoVital);
        }

        EstadoVital IRepositorioEstadoVital.UpdateEstadoVital(HomePetCare.App.Dominio.EstadoVital estadoVital)
        {
            var estadoVitalEncontrado = _appContext.EstadoVitales.FirstOrDefault(c => c.Id == estadoVital.Id);
            if (estadoVitalEncontrado != null)
            {

                estadoVitalEncontrado.FechaHora = estadoVital.FechaHora;

                estadoVitalEncontrado.Valor = estadoVital.Valor;

                estadoVitalEncontrado.Signo = estadoVital.Signo;

                _appContext.SaveChanges();

            }
            return estadoVitalEncontrado;
        }
    }
}