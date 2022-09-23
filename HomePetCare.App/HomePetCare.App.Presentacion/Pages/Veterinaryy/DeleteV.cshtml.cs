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
    public class DeleteVModel : PageModel
    {
        private readonly IRepositorioVeterinary repositorioVeterinary;
        [BindProperty]
        
        public Veterinary veter { set; get; }
        public DeleteVModel()
        {
            this.repositorioVeterinary = new RepositorioVeterinary(new HomePetCare.App.Persistencia.AppContext());
        }

        [HttpGet]
        public IActionResult OnGet(int? idVeterinary)
        {
            if (idVeterinary.HasValue)
            {
                veter = repositorioVeterinary.GetVeterinary(idVeterinary.Value);
            }
            if (veter == null)
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
            if (veter.Id>0)
            {
                repositorioVeterinary.DeleteVeterinary(veter.Id);
            }
            else
            {
                repositorioVeterinary.AddVeterinary(veter);
            }
            return Page();
        }


    }
}
