using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.EntityFrameworkCore.Design;


namespace Migration
{
    class Program
    {

        static void CreateDb()
        {
            var applicationDbContext = new ApplicationDbContext();
            var dbName = applicationDbContext.Database.GetDbConnection().Database;

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
        static void Main(string[] args)
        {
            /*CreateDb();*/

            /*var applicationDbContext = new ApplicationDbContext();

            var kq = applicationDbContext.Database.EnsureDeleted();*/
        }
    }
}
