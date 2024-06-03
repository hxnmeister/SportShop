using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SportShop.Pages
{
    public class ErrorModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet(string error)
        {
            Message = error;
        }
    }
}
