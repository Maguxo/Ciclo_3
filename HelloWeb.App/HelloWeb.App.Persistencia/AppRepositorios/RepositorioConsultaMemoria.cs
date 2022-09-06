using System;
using System.Collections.Generic;
using HelloWeb.App.Dominio;
using System.Linq;


namespace HelloWeb.App.Persistencia.AppRepositorios
{

    public class RepositorioConsultaMemoria : IRepositorioConsulta
    {

        List<Informacion> saludos;

        public RepositorioConsultaMemoria()
        {
            saludos = new List<Informacion>()
            {

                new Informacion{Id=1,EnEspañol="Buenos dias",EnIngles="Good Morning",EnItaliano="BuonGiorno"},
                new Informacion{Id=2,EnEspañol="Buenos tardes",EnIngles="Good afternoon", EnItaliano="Buon pomeriggio"},
                new Informacion{Id=3,EnEspañol="Buenos noches",EnIngles="Good evening", EnItaliano="Buons sera"}

            };
        }

        public IEnumerable<Informacion> GetAll()
        {
            return saludos;
        }

        public IEnumerable<Informacion> GetInformaPorFiltro(string filtro)
        {
            var saludos= GetAll();
            if(saludos != null)
            {
                return saludos;
            }
            return saludos;

        }

        public Informacion GetInformaPorId(int infoId)
        {
            return saludos.SingleOrDefault(s => s.Id == infoId);
        }



    }


}