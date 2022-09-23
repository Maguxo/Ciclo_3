using System;
using System.Collections.Generic;
using System.Linq;
using HomePetCare.App.Dominio;

namespace HomePetCare.App.Persistencia
{
    public interface IRepositorioEstadoVital
    {
       public IEnumerable<EstadoVital> GetAllEstadoVital();
        EstadoVital AddEstadoVital(EstadoVital estadoVital);
        EstadoVital UpdateEstadoVital(EstadoVital estadoVital);
        void DeleteEstadoVital(int idEstadoVital);
        EstadoVital GetEstadoVital(int idEstadoVital);
        
    }
}