using System; 
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HomePetCare.App.Dominio;
using HomePetCare.App.Persistencia;

using Microsoft.AspNetCore.Authorization;

namespace HomePetCare.App.Presentacion.Pages
{
    public class DetailsVModel : PageModel
    {
        private readonly IRepositorioVeterinary repositorioVeterinary;

        public Veterinary veter{get;set;}
        public DetailsVModel()
        {
            this.repositorioVeterinary= new RepositorioVeterinary(new HomePetCare.App.Persistencia.AppContext());
        }

        public IActionResult OnGet(int idVeterinary)
        {
            veter= repositorioVeterinary.GetVeterinary(idVeterinary);
            if(veter == null)
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
