using System;
using System.Collections.Generic;
//clase de la visita domiciliaria
namespace HomePetCare.App.Dominio
{
     /// <summary>Class <c>Visit</c>
    /// Modela un Medico del equipo medico de apoyo 
    /// </summary>  
    public class Visit 
    {
       public int Id{get; set;}
        public string Temperature{get;set;}
        public string Weight {get;set;}
        public string  Breath{get;set;}
        public string RPM{get;set;}
        public string Mood{get;set;}
        public DateTime VisitDate{get;set;}
        public string Commentary{get;set;}    
       
        
    }
}