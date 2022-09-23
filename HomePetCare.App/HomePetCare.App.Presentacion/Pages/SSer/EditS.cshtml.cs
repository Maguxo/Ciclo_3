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
    public class EditSModel : PageModel
    {
        private readonly IRepositorioSer repositorioSer;
        [BindProperty]

        public Ser ser { set; get; }
        public EditSModel()
        {
            this.repositorioSer = new RepositorioSer(new HomePetCare.App.Persistencia.AppContext());
        }
        public IActionResult OnGet(int? idSer)
        {
            if (idSer.HasValue)
            {
                ser = repositorioSer.GetSer(idSer.Value);
            }
            else
            {
                ser = new Ser();
            }
            if (ser == null)
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
            if (ser.Id > 0)
            {
                ser = repositorioSer.UpdateSer(ser);
            }
            else
            {
                repositorioSer.AddSer(ser);
            }
            return Page();
        }

    }

}
