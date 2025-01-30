using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/v{version:ApiVersion}/products")]
    public class ProductsController(IProductService productService) : ApiBaseController
    {
        [HttpGet]
        public async Task<IActionResult> GetAll() 
        {         
            var products = await productService.GetAll();
            return Ok(products);
        }

        [HttpGet("{productId:long}")]
        public async Task<IActionResult> GetById(long productId) 
        {           
            var product = await productService.GetById(productId);
            return Ok();
        }
    }
}
