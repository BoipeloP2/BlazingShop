using BlazingShop.Server.Services.ProductService;
using BlazingShop.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingShop.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productSerivce;

        public ProductController(IProductService productSerivce)
        {
            _productSerivce = productSerivce;
        }

        [HttpGet]

        public async Task<ActionResult<List<Product>>> GetAllProducts()
        {
            return Ok(await _productSerivce.GetAllProducts());
        }

        [HttpGet("Category/{categoryUrl}")]
        public async Task<ActionResult<List<Product>>> GetProductsByCategory( string categoryUrl)
        {
            return Ok(await _productSerivce.GetProductsByCategory(categoryUrl));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            return Ok(await _productSerivce.GetProduct(id));
        }
    }
}
