using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HelloWeb.App.Frontend.Pages
{
   
    public class ListModel : PageModel
    {
         private string [] Saludos= {"Buenos días, ", "Buenas tardes, ","Buenos noches y ", "Hasta mañana"};

    public List<string> ListaSaludos{get;set;}
        public void OnGet()
        {
            ListaSaludos= new List<string>();
            ListaSaludos.AddRange(Saludos);
        }
    }
}
