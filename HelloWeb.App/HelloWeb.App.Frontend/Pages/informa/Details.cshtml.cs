using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HelloWeb.App.Dominio;
using HelloWeb.App.Persistencia.AppRepositorios;

namespace HelloWeb.App.Frontend.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioConsulta repositorioCobsulta;
        public Dog informacion {get;set;}
        public DetailsModel(IRepositorioConsulta repositorioConsulta)
        {
            this.repositorioCobsulta= repositorioConsulta;
        }
        public IActionResult OnGet(int infoId)
        {
             informacion= repositorioCobsulta.GetInformaPorId(infoId);
             if(informacion  ==null)
             {
                return RedirectToPage("./NotFound");
             }
             else
             return Page();
        }
    }
}
