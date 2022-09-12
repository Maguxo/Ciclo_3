using System;
using System.ComponentModel.DataAnnotations;

namespace HelloWeb.App.Dominio
{
    public class Owner
    {
        public int  Id{get;set;}
        [Required(ErrorMessage="Espacio vacio. rellene espacio"), StringLength(50)]
        public string NameOwner {get;set;}
        [Required(ErrorMessage="Espacio vacio. rellene espacio"), StringLength(50)]
        public string  LastNameOwner{get;set;}
        [Required(ErrorMessage="Espacio vacio. rellene espacio"), StringLength(50)]
        public string Address{get;set;}
        [Required(ErrorMessage="Espacio vacio. rellene espacio"), StringLength(50)]
        public string PhoneOwner{get;set;}
        
    }
}