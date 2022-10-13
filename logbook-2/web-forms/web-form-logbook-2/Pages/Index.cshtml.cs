using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Primitives;

namespace web_form_logbook_2.Pages
{
    public class IndexModel : PageModel
    {
        public StringValues FullName;

        public void OnGet()
        {
            FullName = "Arbaaz Patwari";
        }

        public void OnPost()
        {
            this.FullName = Request.Form["FullName"];
        }
    }
}