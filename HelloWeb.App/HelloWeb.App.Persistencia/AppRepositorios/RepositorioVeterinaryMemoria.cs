using System;
using System.Collections.Generic;
using HelloWeb.App.Dominio;
using System.Linq;


namespace HelloWeb.App.Persistencia.AppRepositorios
{

    public class RepositorioVeterinaryMemoria : IRepositorioVeterinary
    {

        List<Veterinary> saludos;

        public RepositorioVeterinaryMemoria()
        {
            saludos = new List<Veterinary>()
            {

                new Veterinary{Id=1,NameVet="josé",LastNameVet="Nuñes",PhoneVet="23235345",ProfCard="23"},
                new Veterinary{Id=2,NameVet="Cristian",LastNameVet="Cardenas",PhoneVet="765435678",ProfCard="54"},
                new Veterinary{Id=3,NameVet="Aurora",LastNameVet="Melon",PhoneVet="87654345",ProfCard="78"}

            };
        }

        public IEnumerable<Veterinary> GetAll()
        {
            return saludos;
        }

        public IEnumerable<Veterinary> GetInformaPorFiltro(string filtro)
        {
            var saludos = GetAll();
            if (saludos != null)
            {
                return saludos;
            }
            return null;

        }

        public Veterinary GetInformaPorId(int infoId)
        {
            return saludos.SingleOrDefault(s => s.Id == infoId);
        }

        public Veterinary Update(Veterinary infoActualizado)
        {
            var saludo = saludos.SingleOrDefault(r => r.Id == infoActualizado.Id);
            if (saludo != null)
            {
                saludo.NameVet = infoActualizado.NameVet;
                saludo.LastNameVet = infoActualizado.LastNameVet;
                saludo.PhoneVet = infoActualizado.PhoneVet;
                saludo.ProfCard = infoActualizado.ProfCard;
                
            }
            return saludo;
        }
        public Veterinary Add(Veterinary nuevoInfo)
        {
            nuevoInfo.Id = saludos.Max(r => r.Id) +1;
            saludos.Add(nuevoInfo);
            return nuevoInfo;
        }
    
    }

}