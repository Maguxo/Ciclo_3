
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
    public class EditVModel : PageModel
    {
        private readonly IRepositorioVeterinary repositorioVeterinary;
        [BindProperty]

        public Veterinary veter { set; get; }
        public EditVModel()
        {
            this.repositorioVeterinary = new RepositorioVeterinary(new HomePetCare.App.Persistencia.AppContext());
        }
        public IActionResult OnGet(int? idVeterinary)
        {
            if (idVeterinary.HasValue)
            {
                veter = repositorioVeterinary.GetVeterinary(idVeterinary.Value);
            }
            else
            {
                veter = new Veterinary();
            }
            if (veter == null)
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
            if (veter.Id>0)
            {
                veter = repositorioVeterinary.UpdateVeterinary(veter);
            }
            else
            {
                repositorioVeterinary.AddVeterinary(veter);
            }
            return Page();
        }

     }

}
