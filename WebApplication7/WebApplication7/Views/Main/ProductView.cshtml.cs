using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP.NET.Views.Main
{
    public class ProductViewModel : PageModel
    {
        public string Mode { get;  set;}
        public IList<Product> Products { get; set; }
        public void OnGet()
        {
        }
    }
}
