using Newtonsoft.Json;
using SportShop.Models;
using System.Collections.Generic;

namespace SportShop.Services
{
    public class ProductService
    {
        private List<Product> products;
        private readonly string pathToData;

        public ProductService(string pathToData)
        {
            this.pathToData = pathToData.Trim();
            Products = JsonConvert.DeserializeObject<List<Product>>(System.IO.File.ReadAllText(this.pathToData));
        }

        public List<Product> Products
        {
            get { return products; }
            private set { products = value; }
        }

        public List<Product> SearchProducts(string searchingParam)
        {
            List<Product> foundProducts = new List<Product>();

            if (decimal.TryParse(searchingParam, out decimal parsedNumber))
            {
                foreach (var item in products)
                {
                    if (item.Id == (int)parsedNumber || item.Price == parsedNumber || item.Weight == (double)parsedNumber)
                    {
                        foundProducts.Add(item);
                        continue;
                    }
                }
            }
            else
            {
                foreach (Product product in products)
                {
                    if (product.Name.Equals(searchingParam, System.StringComparison.CurrentCultureIgnoreCase) ||
                        product.Description.Equals(searchingParam, System.StringComparison.CurrentCultureIgnoreCase))
                    {
                        foundProducts.Add(product);
                        continue;
                    }
                }
            }


            return foundProducts;
        }
    }
}
