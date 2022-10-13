using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Primitives;

namespace web_form_logbook_2.Pages
{
    public class HelloWorldModel : PageModel
    {
        public StringValues name;
        
        public void OnGet()
        {
            name = "Arbaaz Patwari";
        }

        public void OnPost()
        {
            this.name = Request.Form["name"];
        }
    }
}
