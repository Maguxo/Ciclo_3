using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using HelloWeb.App.Persistencia.AppRepositorios;
using HelloWeb.App.Dominio;

namespace HelloWeb.App.Frontend.Pages
{

    public class ListModel : PageModel
    {
        //private string [] Saludos= {"Buenos días, ", "Buenas tardes, ","Buenos noches y ", "Hasta mañana"};
        //public List<string> ListaSaludos { get; set; }
        private readonly IRepositorioConsulta repositorioConsulta;

        public IEnumerable<Dog> informa {get;set;}

        public ListModel(IRepositorioConsulta IrepositorioConsulta)
        {
            this.repositorioConsulta= IrepositorioConsulta;
        }

        public void OnGet()    
        {
            //ListaSaludos = new List<string>();
            //ListaSaludos.AddRange(Saludos);
            informa=repositorioConsulta.GetAll();
        }
    }
}
