using System.Collections.Generic;
using Newtonsoft.Json;
using Shop_API.Models;

namespace Shop_API.Data
{
    public class Seed
    {
        private readonly DataContext _context;
        public Seed(DataContext context)
        {
            _context = context;
        }

        public void SeedProducts()
        {
            var productData = System.IO.File.ReadAllText("Data/ProductDataSeed.json");
            var products = JsonConvert.DeserializeObject<List<Product>>(productData);
            foreach (var product in products)
            {
                _context.Products.Add(product);
            }
            _context.SaveChanges();
        }
    }
}