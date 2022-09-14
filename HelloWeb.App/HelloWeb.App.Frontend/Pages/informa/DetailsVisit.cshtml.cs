using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HelloWeb.App.Dominio;
using HelloWeb.App.Persistencia.AppRepositorios;

namespace HelloWeb.App.Frontend.Pages
{
    public class DetailsVisitModel : PageModel
    {
        private readonly IRepositorioVisit repositorioVisit;
        public Visit informacion { get; set; }
        public DetailsVisitModel(IRepositorioVisit repositorioVisit)
        {
            this.repositorioVisit = repositorioVisit;
        }
        public IActionResult OnGet(int infoId)
        {
            informacion = repositorioVisit.GetInformaPorId(infoId);
            if (informacion == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();
        }
    }
}
