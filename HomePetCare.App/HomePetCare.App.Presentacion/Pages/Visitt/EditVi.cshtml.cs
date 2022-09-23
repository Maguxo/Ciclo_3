
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
    public class EditViModel : PageModel
    {
        private readonly IRepositorioVisit repositorioVisit;
        [BindProperty]

        public Visit visit { set; get; }
        public EditViModel()
        {
            this.repositorioVisit = new RepositorioVisit(new HomePetCare.App.Persistencia.AppContext());
        }
        public IActionResult OnGet(int? idVisit)
        {
            if (idVisit.HasValue)
            {
                visit = repositorioVisit.GetVisit(idVisit.Value);
            }
            else
            {
                visit = new Visit();
            }
            if (visit == null)
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
            if (visit.Id>0)
            {
                visit = repositorioVisit.UpdateVisit(visit);
            }
            else
            {
                repositorioVisit.AddVisit(visit);
            }
            return Page();
        }

     }

}
