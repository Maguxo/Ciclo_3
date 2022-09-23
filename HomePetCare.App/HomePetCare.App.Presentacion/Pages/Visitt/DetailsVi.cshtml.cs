using System; 
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HomePetCare.App.Dominio;
using HomePetCare.App.Persistencia;
using HomePetCare.App.Persistencia;
using Microsoft.AspNetCore.Authorization;

namespace HomePetCare.App.Presentacion.Pages
{
    public class DetailsViModel : PageModel
    {
        private readonly IRepositorioVisit repositorioVisit;

        public Visit visit{get;set;}
        public DetailsViModel()
        {
            this.repositorioVisit= new RepositorioVisit(new HomePetCare.App.Persistencia.AppContext());
        }

        public IActionResult OnGet(int idVisit)
        {
            visit= repositorioVisit.GetVisit(idVisit);
            if(visit == null)
            {
                
                return RedirectToPage("./NotFound");
            }
            else
            {
                return Page(); 
            }

        }
        
    }
}
