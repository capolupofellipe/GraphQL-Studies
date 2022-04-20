using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApi.Interfaces;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProduct _productService;

        public ProductsController(IProduct productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _productService.GetAll();
        }

        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return _productService.Get(id);
        }

        [HttpPost]
        public Product Post([FromBody] Product product)
        {
            return _productService.Add(product);
        }

        [HttpPut("{id}")]
        public Product Put(int id, [FromBody] Product product)
        {
            return _productService.Update(id, product);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _productService.Delete(id);
        }
    }
}
