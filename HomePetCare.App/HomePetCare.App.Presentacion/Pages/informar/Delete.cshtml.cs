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
    public class DeleteModel : PageModel
    {
        private readonly IRepositorioDog repositorioDog;
        [BindProperty]
        
        public Dog dog { set; get; }
        public DeleteModel()
        {
            this.repositorioDog = new RepositorioDog(new HomePetCare.App.Persistencia.AppContext());
        }

        [HttpGet]
        public IActionResult OnGet(int? idDog)
        {
            if (idDog.HasValue)
            {
                dog = repositorioDog.GetDog(idDog.Value);
            }
            if (dog == null)
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
            if (ModelState.IsValid)
            {
                return Page();
            }
            if (dog.Id>0)
            {
                repositorioDog.DeleteDog(dog.Id);
            }
            else
            {
                repositorioDog.AddDog(dog);
            }
            return Page();
        }


    }
}
