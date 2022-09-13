using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HelloWeb.App.Dominio;
using HelloWeb.App.Persistencia.AppRepositorios;

namespace HelloWeb.App.Frontend.Pages
{
    public class DetailsOwnerModel : PageModel
    {
       
        private readonly IRepositorioOwner repositorioOwner;
        public Owner informacion {get;set;}
        public DetailsOwnerModel(IRepositorioOwner repositorioOwner)
        {
            this.repositorioOwner= repositorioOwner;
        }
        public IActionResult OnGet(int infoId)
        {
             informacion= repositorioOwner.GetInformaPorId(infoId);
             if(informacion  ==null)
             {
                return RedirectToPage("./NotFound");
             }
             else
             return Page();
        }
    }
}
