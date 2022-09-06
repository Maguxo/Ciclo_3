using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HelloWeb.App.Persistencia.AppRepositorios;
using HelloWeb.App.Dominio;

namespace HelloWeb.App.Frontend.Pages
{

    public class ListModel : PageModel
    {
        //private string [] Saludos= {"Buenos días, ", "Buenas tardes, ","Buenos noches y ", "Hasta mañana"};
        //public List<string> ListaSaludos { get; set; }
        private readonly IRepositorioConsulta repositorioConsulta;
        public IEnumerable<Informacion> informa { get; set; }

        public ListModel(IRepositorioConsulta repositorioConsulta)
        {
            this.repositorioConsulta = repositorioConsulta;
        }

        public void OnGet()
        {
            //ListaSaludos = new List<string>();
            //ListaSaludos.AddRange(Saludos);
            informa= repositorioConsulta.GetAll();
        }
    }
}
