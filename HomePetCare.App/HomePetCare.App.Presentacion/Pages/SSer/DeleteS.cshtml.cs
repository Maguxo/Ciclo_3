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
    public class DeleteSModel : PageModel
    {
        private readonly IRepositorioSer repositorioSer;
        [BindProperty]

        public Ser ser { set; get; }
        public DeleteSModel()
        {
            this.repositorioSer = new RepositorioSer(new HomePetCare.App.Persistencia.AppContext());
        }

        [HttpGet]
        public IActionResult OnGet(int? idSer)
        {
            if (idSer.HasValue)
            {
                ser = repositorioSer.GetSer(idSer.Value);
            }
            if (ser == null)
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
            if (ser.Id > 0)
            {
                repositorioSer.DeleteSer(ser.Id);
            }
            else
            {
                repositorioSer.AddSer(ser);
            }
            return Page();
        }


    }
}
