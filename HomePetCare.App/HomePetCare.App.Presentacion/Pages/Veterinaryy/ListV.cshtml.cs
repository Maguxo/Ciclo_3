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
    public class ListVModel : PageModel
    {
        private readonly IRepositorioVeterinary repositorioVeterinary;
        public IEnumerable<Veterinary> veter {set;get;}
        public ListVModel()
        {
            this.repositorioVeterinary= new RepositorioVeterinary(new HomePetCare.App.Persistencia.AppContext());
        }
        public void OnGet(string filtrobusqueda)
        {
            veter= repositorioVeterinary.GetAllVeterinary();
        }
    }
}
 