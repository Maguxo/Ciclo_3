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
    public class DetailSModel : PageModel
    {
        private readonly IRepositorioSer repositorioSer;

        public Ser ser { get; set; }
        public DetailSModel()
        {
            this.repositorioSer = new RepositorioSer(new HomePetCare.App.Persistencia.AppContext());
        }

        public IActionResult OnGet(int idSer)
        {
            ser = repositorioSer.GetSer(idSer);
            if (ser == null)
            {

                return RedirectToPage("./NotFound");
            }
            else
            {
                return Page();
            }

        }

    }
}
