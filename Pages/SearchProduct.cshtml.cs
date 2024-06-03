using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SportShop.Models;
using SportShop.Services;
using System.Collections.Generic;

namespace SportShop.Pages
{

    public class SearchProductModel : PageModel
    {
        private ProductService productService;
        public List<Product> Products { get; set; }

        public SearchProductModel(ProductService productService)
        {
            this.productService = productService;
        }

        public IActionResult OnPost(string searchingParam)
        {
            if(string.IsNullOrWhiteSpace(searchingParam))
            {
                return RedirectToPage("Error", new { error = "Searching Text is missing!" });
            }

            Products = productService.SearchProducts(searchingParam);

            if(Products.Count > 0)
            {
                return Page();
            }
            else
            {
                return RedirectToPage("Error", new { error = "No data found!" });
            }
        }

        public IActionResult OnGet()
        {
            return RedirectToPage("Index");
        }
    }
}
