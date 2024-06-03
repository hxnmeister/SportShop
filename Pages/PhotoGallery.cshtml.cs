using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SportShop.Pages
{
    public class PhotoGalleryModel : PageModel
    {
        public IActionResult OnGet()
        {
            return RedirectToPage("/Developing");
        }
    }
}
