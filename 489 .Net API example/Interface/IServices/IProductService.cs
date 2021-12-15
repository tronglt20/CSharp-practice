using _489_.Net_API_example.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _489_.Net_API_example.Interface.IServices
{
    public interface IProductService 
    {
        Task<Product> GetByProductName(string proName);

        Task<IList<Product>> GetAllProduct();
    }
}
