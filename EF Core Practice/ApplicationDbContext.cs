using EF_Core_Practice.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EF_Core_Practice
{
    class ApplicationDbContext : DbContext
    {
        private readonly string connectionString = @"Data Source = localhost; Initial Catalog = mydatabase; Trusted_Connection=True";
        
       protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            base.OnConfiguring(options);
            options.UseSqlServer(connectionString);
            options.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Product> products { get; set; }
        public DbSet<Category> categories { get; set; }

    }
}
