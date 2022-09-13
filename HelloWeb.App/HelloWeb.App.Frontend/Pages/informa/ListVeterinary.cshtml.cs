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
    public class ListVeterinaryModel : PageModel
    {
        private readonly IRepositorioVeterinary repositorioVeterinary;

        public IEnumerable<Veterinary> informa {get;set;}

        public ListVeterinaryModel(IRepositorioVeterinary IrepositorioVeterinary)
        {
            this.repositorioVeterinary= IrepositorioVeterinary;
        }

        public void OnGet()    
        {
            
            informa=repositorioVeterinary.GetAll();
        }
    }
}
