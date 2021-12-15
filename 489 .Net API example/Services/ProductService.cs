using _489_.Net_API_example.Interface;
using _489_.Net_API_example.Interface.IServices;
using _489_.Net_API_example.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _489_.Net_API_example.Services
{
    public class ProductService : IProductService
    {
        private IProductRepository _repository;
        //private IRepository<Product> _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public Task<Product> GetByProductName(string proName)
        {
            return _repository.FindAsync(proName);
        }

        public async Task<IList<Product>> GetAllProduct()
        {
            
            return await _repository.GetAllAsync();
        }
    }
}
