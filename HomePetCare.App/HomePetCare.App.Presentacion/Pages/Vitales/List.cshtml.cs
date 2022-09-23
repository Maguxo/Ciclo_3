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
    public class LiistModel : PageModel
    {
        private readonly IRepositorioEstadoVital repositorioEstadoVital;
        public IEnumerable<EstadoVital> estadoV {set;get;}
        public LiistModel()
        {
            this.repositorioEstadoVital= new RepositorioEstadoVital(new HomePetCare.App.Persistencia.AppContext());
        }
        public void OnGet(string filtrobusqueda)
        {
            estadoV= repositorioEstadoVital.GetAllEstadoVital();
        }
    }
}
 