using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_Practice_DI.Services;

namespace WebAPI_Practice_DI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ProductServices _productServices;

        public HomeController(ProductServices productServices)
        {
            _productServices = productServices;
        }

        // GET: api/<example>
        [HttpGet]
        public string Get()
        {
            return "Khong co du lieu";
        }

        // GET api/<example>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            var product = _productServices.FindProduct(id);
            if (product is null) {
                return "Khong co du lieu";
            }
            return $"{product.Id}: {product.Name} - {product.Price}";
        }


    }
}
