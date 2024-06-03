using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using SportShop.Models;
using SportShop.Services;
using System.Collections.Generic;
using System.IO;

namespace SportShop.Pages
{
    public class OurProductsModel : PageModel
    {
        private ProductService productService;
        public List<Product> Products { get; set; }

        public OurProductsModel(ProductService productService) 
        {
            this.productService = productService;
        }

        public void OnGet()
        {
            Products = productService.Products;
        }
    }
}
