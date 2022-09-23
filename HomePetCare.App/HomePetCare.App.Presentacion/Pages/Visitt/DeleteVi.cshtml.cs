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
    public class DeleteViModel : PageModel
    {
        private readonly IRepositorioVisit repositorioVisit;
        [BindProperty]
        
        public Visit visit { set; get; }
        public DeleteViModel()
        {
            this.repositorioVisit = new RepositorioVisit(new HomePetCare.App.Persistencia.AppContext());
        }

        [HttpGet]
        public IActionResult OnGet(int? idVisit)
        {
            if (idVisit.HasValue)
            {
                visit = repositorioVisit.GetVisit(idVisit.Value);
            }
            if (visit == null)
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
            if (visit.Id>0)
            {
                repositorioVisit.DeleteVisit(visit.Id);
            }
            else
            {
                repositorioVisit.AddVisit(visit);
            }
            return Page();
        }


    }
}
