using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HelloWeb.App.Dominio;
using HelloWeb.App.Persistencia.AppRepositorios;

namespace HelloWeb.App.Frontend.Pages
{
    public class DetailsVeterinaryModel : PageModel
    {
       private readonly IRepositorioVeterinary repositorioVeterinary;
        public Veterinary informacion {get;set;}
        public DetailsVeterinaryModel(IRepositorioVeterinary repositorioVeterinary)
        {
            this.repositorioVeterinary= repositorioVeterinary;
        }
        public IActionResult OnGet(int infoId)
        {
             informacion= repositorioVeterinary.GetInformaPorId(infoId);
             if(informacion  ==null)
             {
                return RedirectToPage("./NotFound");
             }
             else
             return Page();
        }
    }
}
