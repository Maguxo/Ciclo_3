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
    public class ListOwnerModel : PageModel
    {
         private readonly IRepositorioOwner repositoriOwner;

        public IEnumerable<Owner> informaOwner {get;set;}

        public ListOwnerModel(IRepositorioOwner IrepositoriOwner)
        {
            this.repositoriOwner= IrepositoriOwner;
        }

        public void OnGet()    
        {
            informaOwner=repositoriOwner.GetAll();
        }   
    }
}
