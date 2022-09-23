using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomePetCare.App.Dominio;
using HomePetCare.App.Persistencia;

using Microsoft.AspNetCore.Authorization;

namespace HomePetCare.App.Presentacion.Pages
{
    public class ListViModel : PageModel
    {
        private readonly IRepositorioVisit repositorioVisit;
        public IEnumerable<Visit> visits {set;get;}
        public ListViModel()
        {
            this.repositorioVisit= new RepositorioVisit(new HomePetCare.App.Persistencia.AppContext());
        }
        public void OnGet(string filtrobusqueda)
        {
            visits= repositorioVisit.GetAllVisit();
        }
    }
}
