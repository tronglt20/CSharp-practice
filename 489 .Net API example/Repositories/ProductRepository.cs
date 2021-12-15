using _489_.Net_API_example.Interface;
using _489_.Net_API_example.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _489_.Net_API_example.Repositories
{
    public class ProductRepository : Repository<Product> ,IProductRepository
    {
        public ProductRepository(ApplicationDbContext context) : base(context)
        {

        }    


    }
}
