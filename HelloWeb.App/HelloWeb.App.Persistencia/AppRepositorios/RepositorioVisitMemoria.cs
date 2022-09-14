using System;
using System.Collections.Generic;
using HelloWeb.App.Dominio;
using System.Linq;


namespace HelloWeb.App.Persistencia.AppRepositorios
{

    public class RepositorioVisitMemoria : IRepositorioVisit
    {

        List<Visit> saludos;

        public RepositorioVisitMemoria()
        {
            saludos = new List<Visit>()
            {

                new Visit{Id=1,Temperature="26°c",Weight="23kg",Breath="12",RPM="12",Mood="normal",VisitDate="12/12/12",IdVet="23",IdDog="345",Commentary="nada"},
                new Visit{Id=2,Temperature="28°c",Weight="32kg",Breath="15",RPM="13",Mood="normal",VisitDate="0712/23",IdVet="45",IdDog="542",Commentary="nada"},
                new Visit{Id=3,Temperature="23°c",Weight="12kg",Breath="18",RPM="15",Mood="normal",VisitDate="09/23/22",IdVet="67",IdDog="100",Commentary="nada"}
                    
            };
        }

        public IEnumerable<Visit> GetAll()
        {
            return saludos;
        }

        public IEnumerable<Visit> GetInformaPorFiltro(string filtro)
        {
            var saludos = GetAll();
            if (saludos != null)
            {
                return saludos;
            }
            return null;

        }

        public Visit GetInformaPorId(int infoId)
        {
            return saludos.SingleOrDefault(s => s.Id == infoId);
        }

        public Visit Update(Visit infoActualizado)
        {
            var saludo = saludos.SingleOrDefault(r => r.Id == infoActualizado.Id);
            if (saludo != null)
            {
                saludo.Temperature = infoActualizado.Temperature;
                saludo.Weight = infoActualizado.Weight;
                saludo.Breath = infoActualizado.Breath;
                saludo.RPM = infoActualizado.RPM;
                saludo.Mood = infoActualizado.Mood;
                saludo.VisitDate = infoActualizado.VisitDate;
                saludo.IdVet = infoActualizado.IdVet;
                saludo.IdDog = infoActualizado.IdDog;
                saludo.Commentary = infoActualizado.Commentary;
                
                 
                }
                return saludo;
                
            
            
        }
        public Visit Add(Visit nuevoInfo)
        {
            nuevoInfo.Id = saludos.Max(r => r.Id) +1;
            saludos.Add(nuevoInfo);
            return nuevoInfo;
        }
    
    }
}
