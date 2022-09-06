
//clase de la visita domiciliaria
namespace HomePetCare.App.Dominio
{
    public class Visit
    {
        public int Id{get; set;}
        public string Temperature{get;set;}
        public string Weight {get;set;}
        public String  Breath{get;set;}
        public string RPM{get;set;}
        public string Mood{get;set;}
        public string VisitDate{get;set;}
        public string IdVet{get;set;}
        public string IdDog{get;set;}
        public string Commentary{get;set;}    
    }
}