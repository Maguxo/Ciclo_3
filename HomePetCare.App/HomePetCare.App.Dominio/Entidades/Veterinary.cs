using System;
//clase veterinario
namespace HomePetCare.App.Dominio
{ 
    /// <summary>Class <c>Veterinary</c>
    /// Modela un Medico del equipo medico de apoyo 
    /// </summary>  
    public class Veterinary 
    { 
      
        public int Id{get; set;}
        public string NameVet{get;set;}
        public string LastNameVet {get;set;}
        public string  PhoneVet{get;set;}
        public string ProfCard{get;set;}
        
    }
}