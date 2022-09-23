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
    public class ListModel : PageModel
    {
        private readonly IRepositorioDog repositorioDog;
        public IEnumerable<Dog> dog {set;get;}
        public ListModel()
        {
            this.repositorioDog= new RepositorioDog(new HomePetCare.App.Persistencia.AppContext());
        }
        public void OnGet(string filtrobusqueda)
        {
            dog= repositorioDog.GetAllDog();
        }
    }
}
 