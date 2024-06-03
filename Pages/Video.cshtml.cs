using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SportShop.Pages
{
    public class VideoModel : PageModel
    {
        public IActionResult OnGet()
        {
            return RedirectToPage("/Developing");
        }
    }
}
