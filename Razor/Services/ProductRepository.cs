using Current2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Current2.Services
{
    public class ProductRepository : IProductRepository
    {
        private Dictionary<string, Product> products;
        public ProductRepository()
        {
            products = new Dictionary<string, Product>()
            {
                ["Kayak"] = new Product { Name = "Kayak", Price = 27000M, Stock = 2 },
                ["Lifejacket"] = new Product { Name = "Lifejacket", Price = 48.95M, Stock = 4 },
                ["Soccer ball"] = new Product { Name = "Soccer ball", Price = 19.50M, Stock = 4 },
                ["Corner flag"] = new Product { Name = "Corner flag", Price = 34.95M, Stock = 1 }
            };
        }
        
        public IEnumerable<Product> Entities => products.Values;
        public void AddProduct(Product entity) => products.Add(entity.Name, entity);
    }
}
