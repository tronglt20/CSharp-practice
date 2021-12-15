using Microsoft.EntityFrameworkCore;
using Migration.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Migration
{
    public class ApplicationDbContext : DbContext
    {
        private string ConnectionString = @"Data Source = localhost; Initial Catalog = MigrationDB; Trusted_Connection=True";
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            base.OnConfiguring(options);
            options.UseSqlServer(ConnectionString);
        }

        public DbSet<Card> cards { get; set; }
        public DbSet<Todo> todos { get; set; }
    }
}
