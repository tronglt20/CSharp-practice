using EF_Core_Practice.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace EF_Core_Practice
{
    class Program
    {
        static void CreateDb()
        {
            var applicationDbContext = new ApplicationDbContext();
            string dbName = applicationDbContext.Database.GetDbConnection().Database;

            var kq = applicationDbContext.Database.EnsureCreated();

            if (kq)
            {
                Console.WriteLine("Connection success");
            }
            else
            {
                Console.WriteLine("Connection fail");
            }

        }

        static void DropDb()
        {
            var applicationDbContext = new ApplicationDbContext();
            string dbName = applicationDbContext.Database.GetDbConnection().Database;

            var kq = applicationDbContext.Database.EnsureDeleted();

            if (kq)
            {
                Console.WriteLine("Delete success");
            }
            else
            {
                Console.WriteLine("Delete fail");
            }

        }

        static void InsertProduct()
        {
            using var context = new ApplicationDbContext();

            var category = new Category[]
            {
                new Category{ Name = "Samsung"},
                new Category{ Name = "Iphone"}
            };

            var product = new Product[]
            {
               new Product{Name = "P1",Price = 2000,CateId = 3},
               new Product{Name = "P2",Price = 4500,CateId = 3},
               new Product{Name = "P3",Price = 3000,CateId = 3},
               new Product{Name = "P4",Price = 4000,CateId = 4},
               new Product{Name = "P5",Price = 4000,CateId = 4},
               new Product{Name = "P6",Price = 4000,CateId = 4},
            };
            context.AddRange(category);
            context.AddRange(product);
            var numRow = context.SaveChanges();
            Console.WriteLine($"Inserted {numRow} product");
        }

        static void ReadProduct()
        {
            using var context = new ApplicationDbContext();
            var products = context.products.ToList();
            foreach(var p in products)
            {
                Console.WriteLine($"Product name: {p.Name} / Price: {p.Price} / CateId: {p.CateId}");
/*
                var a = context.Entry(p);
                a.Reference(a => a.category).Load();*/

                if(p.category != null)
                {
                    Console.WriteLine($"Category: {p.category.Name}");
                }
                else Console.WriteLine("Khong co category");
            }
        }

        static void ReadCategory()
        {
            using var context = new ApplicationDbContext();
            var categories = context.categories.ToList();

            foreach (var cate in categories)
            {
                Console.WriteLine($"Product Id: {cate.Id} / Name: {cate.Name}");

          /*      var p = context.Entry(cate);
                p.Collection(p => p.Products).Load();*/

                if (cate.Products != null)
                {
                    foreach(var x in cate.Products)
                    {
                        Console.WriteLine($"Product name: {x.Name} / Price: {x.Price}");
                    }
                }
                else Console.WriteLine("Khong co Product");
            }
        }

        static void UpdateProduct(int id)
        {
            using var context = new ApplicationDbContext();
            var isUpdated = 0;
            var product = (from p in context.products
                          where p.Id == id
                          select p).FirstOrDefault();
            if(product != null)
            {
                Console.WriteLine($"Update product {product.Name}");
                var newName = Console.ReadLine();

                Console.WriteLine($"Update product {product.Price}");
                var newPrice = Convert.ToDouble(Console.ReadLine());

                product.Name = newName;
                product.Price = newPrice;
                isUpdated = context.SaveChanges();

            }

            if (isUpdated != 0)
            {
                Console.WriteLine("Update success");
            }
            else
            {
                Console.WriteLine("Update fail");
            }
        }
        static void Main(string[] args)
        {

            /*DropDb();*/

            /*CreateDb();*/

            /*InsertProduct();*/

            /*ReadProduct();*/

            ReadCategory();

            /*UpdateProduct(6);*/
        }
    }
}
