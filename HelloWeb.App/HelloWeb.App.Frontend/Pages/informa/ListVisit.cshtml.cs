using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using HelloWeb.App.Persistencia.AppRepositorios;
using HelloWeb.App.Dominio;

namespace HelloWeb.App.Frontend.Pages
{
    public class ListVisitModel : PageModel
    {
        private readonly IRepositorioVisit repositorioVisit;

        public IEnumerable<Visit> informa { get; set; }

        public ListVisitModel(IRepositorioVisit IrepositorioVisit)
        {
            this.repositorioVisit = IrepositorioVisit;
        }

        public void OnGet()
        {
            informa = repositorioVisit.GetAll();
        }
    }
}
