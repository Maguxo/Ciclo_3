
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
    public class EditModel : PageModel
    {
        private readonly IRepositorioDog repositorioDog;
        [BindProperty]

        public Dog dog { set; get; }
        public EditModel()
        {
            this.repositorioDog = new RepositorioDog(new HomePetCare.App.Persistencia.AppContext());
        }
        public IActionResult OnGet(int? idDog)
        {
            if (idDog.HasValue)
            {
                dog = repositorioDog.GetDog(idDog.Value);
            }
            else
            {
                dog = new Dog();
            }
            if (dog == null)
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
            if (ModelState.IsValid)
            {
                return Page();
            }
            if (dog.Id>0)
            {
                dog = repositorioDog.UpdateDog(dog);
            }
            else
            {
                repositorioDog.AddDog(dog);
            }
            return Page();
        }

     }

}
