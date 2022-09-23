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
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioDog repositorioDog;

        public Dog dog{get;set;}
        public DetailsModel()
        {
            this.repositorioDog= new RepositorioDog(new HomePetCare.App.Persistencia.AppContext());
        }

        public IActionResult OnGet(int idDog)
        {
            dog= repositorioDog.GetDog(idDog);
            if(dog == null)
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
