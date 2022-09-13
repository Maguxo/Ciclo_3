
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
    public class EditVeterinaryModel : PageModel
    {
        private readonly IRepositorioVeterinary repositorioVeterinary;
        [BindProperty]
        public Veterinary informacion { get; set; }
        public EditVeterinaryModel(IRepositorioVeterinary repositorioVeterinary)
        {
            this.repositorioVeterinary = repositorioVeterinary;
        }
        public IActionResult OnGet(int? infoId)
        {
            if (infoId.HasValue)
            {
                informacion = repositorioVeterinary.GetInformaPorId(infoId.Value);
            }
            else
            {
                informacion = new Veterinary();
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
                informacion = repositorioVeterinary.Update(informacion);
            }
            else
            {
                repositorioVeterinary.Add(informacion);
            }
            return Page();
        }
    }
}
