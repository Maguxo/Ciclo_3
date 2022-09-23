using System;

//clase perro
namespace HomePetCare.App.Dominio
{
    
    public class Dog 
    {
       public int Id{get;set;}
        public string NameVDog {get;set;}
        public string  Breed{get;set;}
        public DateTime FechaNacimiento{get;set;}
        public string Color{get;set;}
 
         public Veterinary veterinario{get;set;}
         public Visit visita{get;set;}

         public Owner dueño{get; set;}
         
       public System.Collections.Generic.List<EstadoVital> Estado{get;set;}
    }
}