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
    public class DeleeteModel : PageModel
    {
        private readonly IRepositorioEstadoVital repositorioEstadoVital;
        [BindProperty]
        
        public EstadoVital estadoV { set; get; }
        public DeleeteModel()
        {
            this.repositorioEstadoVital = new RepositorioEstadoVital(new HomePetCare.App.Persistencia.AppContext());
        }

        [HttpGet]
        public IActionResult OnGet(int? idEstadoVital)
        {
            if (idEstadoVital.HasValue)
            {
                estadoV = repositorioEstadoVital.GetEstadoVital(idEstadoVital.Value);
            }
            if (estadoV == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            {
                return Page();
            }
        }

         [HttpGet]
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (estadoV.Id>0)
            {
                repositorioEstadoVital.DeleteEstadoVital(estadoV.Id);
            }
            else
            {
                repositorioEstadoVital.AddEstadoVital(estadoV);
            }
            return Page();
        }


    }
}
