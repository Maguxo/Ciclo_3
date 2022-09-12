using System;
using System.Collections.Generic;
using HelloWeb.App.Dominio;

namespace HelloWeb.App.Persistencia.AppRepositorios
{

    public interface IRepositorioConsulta
    {
        public IEnumerable<Dog> GetAll();
        IEnumerable<Dog> GetInformaPorFiltro(string filtro);

        Dog GetInformaPorId(int infoId);
         
        Dog Update(Dog infoActualizado);
        Dog Add(Dog nuevoInfo);

        
    }
}