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
    public class ListSModel : PageModel
    {
        private readonly IRepositorioSer repositorioSer;
        public IEnumerable<Ser> ser { set; get; }
        public ListSModel()
        {
            this.repositorioSer = new RepositorioSer(new HomePetCare.App.Persistencia.AppContext());
        }
        public void OnGet(string filtrobusqueda)
        {
            ser = repositorioSer.GetAllSer();
        }


    }
}

