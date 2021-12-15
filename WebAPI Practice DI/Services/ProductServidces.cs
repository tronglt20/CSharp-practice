using System;
using System.Collections.Generic;
using System.Linq;

namespace WebAPI_Practice_DI.Services
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public double Price { get; set; }
    }

    public class ProductServices
    {
        List<Product> products = new List<Product>();

        public ProductServices()
        {
            products.AddRange(new Product[] {
                new Product(){ Id = 1, Name = "Product 1", Price = 200},
                new Product(){ Id = 2, Name = "Product 2", Price = 550},
                new Product(){ Id = 3, Name = "Product 3", Price = 2000},
                new Product(){ Id = 4, Name = "Product 4", Price = 900},
            });
        }

        public Product FindProduct(int id)
        {
            var product = from p in products where p.Id == id select p;
            return product.FirstOrDefault();
        }
    }
}
