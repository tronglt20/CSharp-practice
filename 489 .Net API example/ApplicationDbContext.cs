using _489_.Net_API_example.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _489_.Net_API_example
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            var category = new Category[]
         {
                new Category{Id=1, Name = "Samsung"},
                new Category{Id=2, Name = "Iphone"}
         };

            var product = new Product[]
            {
               new Product{Id=1, Name = "P1",Price = 2000,CateId = 1},
               new Product{Id=2,Name = "P2",Price = 4500,CateId = 1},
               new Product{Id=3,Name = "P3",Price = 3000,CateId = 1},
               new Product{Id=4,Name = "P4",Price = 4000,CateId = 2},
               new Product{Id=5,Name = "P5",Price = 4000,CateId = 2},
               new Product{Id=6,Name = "P6",Price = 4000,CateId = 2},
            };

            builder.Entity<Category>().HasData(category);
            builder.Entity<Product>().HasData(product);

        }
        public DbSet<Product> products{ get; set; }
        public DbSet<Category> categories { get; set; }  
    }
}
