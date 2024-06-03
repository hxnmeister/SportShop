using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SportShop.Pages
{
    public class DevelopingModel : PageModel
    {
        public IActionResult OnGet()
        {
            string redirection = HttpContext.Request.Headers["Referer"].ToString();

            if (string.IsNullOrEmpty(redirection))
            {
                return RedirectToPage("Index");
            }

            return Page();
        }
    }
}
