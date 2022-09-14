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
    public class EditVisitModel : PageModel
    {
        private readonly IRepositorioVisit repositorioVisit;
        [BindProperty]
        public Visit informacion { get; set; }
        public EditVisitModel(IRepositorioVisit repositorioVisit)
        {
            this.repositorioVisit = repositorioVisit;
        }
        public IActionResult OnGet(int? infoId)
        {
            if (infoId.HasValue)
            {
                informacion = repositorioVisit.GetInformaPorId(infoId.Value);
            }
            else
            {
                informacion = new Visit();
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
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (informacion.Id > 0)
            {
                informacion = repositorioVisit.Update(informacion);
            }
            else
            {
                repositorioVisit.Add(informacion);
            }
            return Page();
        }
    }
}
