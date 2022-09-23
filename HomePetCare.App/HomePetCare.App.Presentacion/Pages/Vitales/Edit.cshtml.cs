using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HomePetCare.App.Persistencia;

using HomePetCare.App.Dominio;
using Microsoft.AspNetCore.Authorization;

namespace HomePetCare.App.Presentacion.Pages
{
    public class EdiitModel : PageModel
    {
        private readonly IRepositorioEstadoVital repositorioEstadoVital;
        [BindProperty]

        public EstadoVital estadoV { set; get; }
        public EdiitModel()
        {
            this.repositorioEstadoVital = new RepositorioEstadoVital(new HomePetCare.App.Persistencia.AppContext());
        }
        public IActionResult OnGet(int? idEstadoVital)
        {
            if (idEstadoVital.HasValue)
            {
                estadoV = repositorioEstadoVital.GetEstadoVital(idEstadoVital.Value);
            }
            else
            {
                estadoV = new EstadoVital();
            }
            if (estadoV == null)
            {
                return RedirectToPage("./Notfound");
            }
            else
            {
                return Page();
            }
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (estadoV.Id>0)
            {
                estadoV = repositorioEstadoVital.UpdateEstadoVital(estadoV);
            }
            else
            {
                repositorioEstadoVital.AddEstadoVital(estadoV);
            }
            return Page();
        }

     }

}
