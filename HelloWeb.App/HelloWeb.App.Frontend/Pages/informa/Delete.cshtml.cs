using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using HelloWeb.App.Persistencia.AppRepositorios;
using HelloWeb.App.Dominio;

namespace HelloWeb.App.Frontend.Pages
{
    public class DeleteModel : PageModel
    {

        private readonly IRepositorioConsulta repositorioCobsulta;
        [BindProperty]
        public Dog informacion { get; set; }
       
        public IActionResult OnGet(int? infoId)
        {
            if (infoId.HasValue)
            {
                informacion = repositorioCobsulta.GetInformaPorId(infoId.Value);
            }
            else
            {
                informacion = new Dog();
            }
            if (informacion == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();
        }
        public IActionResult OnPost()
        {
            if (informacion.Id > 0)
            {
               // informacion = repositorioCobsulta.Remove(informacion);
            }
            else
            {
                repositorioCobsulta.Add(informacion);
            }
            return Page();
        }
    }
}

