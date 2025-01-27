using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/v{version:ApiVersion}/products")]
    public class ProductsController(ILogger<ProductsController> logger) : ApiBaseController
    {
        [HttpGet]
        public async Task<IActionResult> GetAll() 
        {
            logger.LogInformation($"[{DateTime.Now}] url: {Url.Action()}, method: GetAll started. Request:");
            ///service
            logger.LogInformation($"[{DateTime.Now}] url: {Url.Action()}, method: GetAll finished. Request: Responce");

            return Ok();
        }

        [HttpGet("{productId:long}")]
        public async Task<IActionResult> GetById(long productId) 
        {
            logger.LogInformation($"[{DateTime.Now}] url: {Url.Action()}, method: GetAll started. Request:");
            ///service
            logger.LogInformation($"[{DateTime.Now}] url: {Url.Action()}, method: GetAll finished. Request: Responce");

            return Ok();
        }
    }
}
