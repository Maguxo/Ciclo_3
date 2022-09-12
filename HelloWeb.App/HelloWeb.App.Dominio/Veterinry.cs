using System;
using System.ComponentModel.DataAnnotations;
//clase veterinario
namespace HelloWeb.App.Dominio
{
    public class Veterinary
    { 
        public int Id{get;set;}
        [Required(ErrorMessage="Espacio vacio. rellene espacio"), StringLength(50)]
        public string NameVet{get;set;}
        [Required(ErrorMessage="Espacio vacio. rellene espacio"), StringLength(50)]
        public string LastNameVet {get;set;}
        [Required(ErrorMessage="Espacio vacio. rellene espacio"), StringLength(50)]
        public int  PhoneVet{get;set;}
        [Required(ErrorMessage="Espacio vacio. rellene espacio"), StringLength(50)]
        public string ProfCard{get;set;}
        
    }
}