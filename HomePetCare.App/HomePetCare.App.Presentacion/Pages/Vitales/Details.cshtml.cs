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
    public class DetaailsModel : PageModel
    {
        private readonly IRepositorioEstadoVital repositorioEstadoVital;

        public EstadoVital estadoV{get;set;}
        public DetaailsModel()
        {
            this.repositorioEstadoVital= new RepositorioEstadoVital(new HomePetCare.App.Persistencia.AppContext());
        }

        public IActionResult OnGet(int idEstadoVital)
        {
            estadoV= repositorioEstadoVital.GetEstadoVital(idEstadoVital);
            if(estadoV == null)
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
