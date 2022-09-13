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
    public class EdithOwnerModel : PageModel
    {
        
        private readonly IRepositorioOwner repositorioOwner;
        [BindProperty]
        public Owner informacion { get; set; }
        public EdithOwnerModel(IRepositorioOwner repositorioOwner)
        {
            this.repositorioOwner = repositorioOwner;
        }
        public IActionResult OnGet(int? infoId)
        {
            if (infoId.HasValue)
            {
                informacion = repositorioOwner.GetInformaPorId(infoId.Value);
            }
            else
            {
                informacion = new Owner();
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
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if (informacion.Id>0)
            {
                informacion = repositorioOwner.Update(informacion);
            }
            else
            {
                repositorioOwner.Add(informacion);
            }
            return Page();
        }
    }
}
