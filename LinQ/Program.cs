using System;
using System.Collections.Generic;
using System.Linq;

namespace LinQ
{
    class Program
    {
     
        static void Main(string[] args)
        {
            var brands = new List<Brand>() {
                new Brand{ID = 1, Name = "Công ty AAA"},
                new Brand{ID = 2, Name = "Công ty BBB"},
                new Brand{ID = 4, Name = "Công ty CCC"},
            };


            var products = new List<Product>()
            {
                new Product(1, "Bàn trà",    400, new string[] {"Xám", "Xanh"},         2),
                new Product(2, "Tranh treo", 400, new string[] {"Vàng", "Xanh"},        1),
                new Product(3, "Đèn trùm",   500, new string[] {"Trắng"},               3),
                new Product(4, "Bàn học",    200, new string[] {"Trắng", "Xanh"},       1),
                new Product(5, "Túi da",     300, new string[] {"Đỏ", "Đen", "Vàng"},   2),
                new Product(6, "Giường ngủ", 500, new string[] {"Trắng"},               2),
                new Product(7, "Tủ áo",      600, new string[] {"Trắng"},               3),
            };


            // LinQ
            var result = from product in products
                         where product.Price == 400
                         /*select new
                         { ten = product.Name.ToUpper(),
                           mausac = string.Join(',',product.Colors)
                         };*/
                         group product by product.Price;

            foreach(var group in result)
            {
                Console.WriteLine(group.Key);
                foreach(var product in group)
                {
                    Console.WriteLine(product.Name);

                }
            }
        }
    }
}
