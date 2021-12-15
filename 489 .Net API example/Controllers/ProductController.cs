using _489_.Net_API_example.Interface;
using _489_.Net_API_example.Interface.IServices;
using _489_.Net_API_example.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _489_.Net_API_example.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController
    {
        /*private IProductRepository _repository;*/

        private IProductService _service;
        private IProductRepository repository;

        public ProductController(IProductService _service, IProductRepository repository)
        {
            this._service = _service;
            this.repository = repository;
        }

        [HttpGet]
        public async Task<IList<Product>> Get()
        {
            return await _service.GetAllProduct();
        }
    }
}
