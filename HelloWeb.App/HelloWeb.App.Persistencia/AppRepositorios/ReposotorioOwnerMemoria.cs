using System;
using System.Collections.Generic;
using HelloWeb.App.Dominio;
using System.Linq;


namespace HelloWeb.App.Persistencia.AppRepositorios
{

    public class RepositorioOwnerMemoria : IRepositorioOwner
    {

        List<Owner> saludos;

        public RepositorioOwnerMemoria()
        {
            saludos = new List<Owner>()
            {

                new Owner{Id=1,NameOwner="pedro",LastNameOwner="Pérez",Address="calle 33#3-9",PhoneOwner="1234567"},
                new Owner{Id=2,NameOwner="Juan",LastNameOwner="Rodriguez",Address="Kr 3#37-9",PhoneOwner="765432"},
                new Owner{Id=3,NameOwner="Elber",LastNameOwner="Saenz",Address="Av 34#3-9",PhoneOwner="23456"}

            };
        }

        public IEnumerable<Owner> GetAll()
        {
            return saludos;
        }

        public IEnumerable<Owner> GetInformaPorFiltro(string filtro)
        {
            var saludos = GetAll();
            if (saludos != null)
            {
                return saludos;
            }
            return null;

        }

        public Owner GetInformaPorId(int infoId)
        {
            return saludos.SingleOrDefault(s => s.Id == infoId);
        }

        public Owner Update(Owner infoActualizado)
        {
            var saludo = saludos.SingleOrDefault(r => r.Id == infoActualizado.Id);
            if (saludo != null)
            {
                saludo.NameOwner = infoActualizado.NameOwner;
                saludo.LastNameOwner = infoActualizado.LastNameOwner;
                saludo.Address = infoActualizado.Address;
                saludo.PhoneOwner = infoActualizado.PhoneOwner;
                
            }
            return saludo;
        }
        public Owner Add(Owner nuevoInfo)
        {
            nuevoInfo.Id = saludos.Max(r => r.Id) +1;
            saludos.Add(nuevoInfo);
            return nuevoInfo;
        }
    }


}