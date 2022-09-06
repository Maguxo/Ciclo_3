using System;
using System.Collections.Generic;
using HelloWeb.App.Dominio;

namespace HelloWeb.App.Persistencia.AppRepositorios
{

    public interface IRepositorioConsulta
    {
        public IEnumerable<Informacion> GetAll();
        IEnumerable<Informacion> GetInformaPorFiltro(string filtro);

        Informacion GetInformaPorId(int infoId);
    }
}