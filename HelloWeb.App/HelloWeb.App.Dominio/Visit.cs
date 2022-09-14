using System;
using System.ComponentModel.DataAnnotations;
//clase de la visita domiciliaria
namespace HelloWeb.App.Dominio
{
    public class Visit
    {
        public int Id{get; set;}
        [Required(ErrorMessage="Espacio vacio. rellene espacio"), StringLength(50)]
        public string Temperature{get;set;}
        [Required(ErrorMessage="Espacio vacio. rellene espacio"), StringLength(50)]
        public string Weight {get;set;}
        [Required(ErrorMessage="Espacio vacio. rellene espacio"), StringLength(50)]
        public string  Breath{get;set;}
        [Required(ErrorMessage="Espacio vacio. rellene espacio"), StringLength(50)]
        public string RPM{get;set;}
        [Required(ErrorMessage="Espacio vacio. rellene espacio"), StringLength(50)]
        public string Mood{get;set;}
        [Required(ErrorMessage="Espacio vacio. rellene espacio"), StringLength(50)]
        public string VisitDate{get;set;}
        [Required(ErrorMessage="Espacio vacio. rellene espacio"), StringLength(50)]
        public string IdVet{get;set;}
        [Required(ErrorMessage="Espacio vacio. rellene espacio"), StringLength(50)]
        public string IdDog{get;set;}
        [Required(ErrorMessage="Espacio vacio. rellene espacio"), StringLength(50)]
        public string Commentary{get;set;}    
    }
}