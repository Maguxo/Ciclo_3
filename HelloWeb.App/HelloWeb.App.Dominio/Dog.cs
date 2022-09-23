using System;
using System.ComponentModel.DataAnnotations;

namespace HelloWeb.App.Dominio
{
    public class Dog
    {
        public int Id { get; set; }
        [Required(ErrorMessage="Espacio vacio. rellene espacio"), StringLength(50)]
        public string NameDog { get; set; }
        [Required(ErrorMessage="Espacio vacio. rellene espacio"), StringLength(50)]

        public string Breed { get; set; }
        
       public Veterinary Veterinary{get;set;}
        //public TipoVital signo{get;set;}
         public System.Collections.Generic.List<Owner> dueño{get; set;}
       
       
        
    }
}

