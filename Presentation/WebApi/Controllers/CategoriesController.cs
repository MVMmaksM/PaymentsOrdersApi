using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApi.Controllers
{
    [Route("api/v{version:apiVersion}/categories")]
    public class CategoriesController(ILogger<CategoriesController> logger, ICategoryService categoryService) : ApiBaseController
    {
        [HttpGet]
        public async Task<IActionResult> GetAll(ApiVersion apiVersion)
        {           
            logger.LogInformation($"[{DateTime.Now}] url: {Url.Action()}, method: GetAll started. Request:");
            var categories = await categoryService.GetAll();
            logger.LogInformation($"[{DateTime.Now}] url: {Url.Action()}, method: GetAll finished. Request: Responce");

            return Ok(categories);
        }

        [HttpGet("{categoryId:long}")]
        public async Task<IActionResult> GetById(ApiVersion apiVersion, long categoryId) 
        {
            logger.LogInformation($"[{DateTime.Now}] url: {Url.Action()}, method: GetAll started. Request:");
            ///service
            logger.LogInformation($"[{DateTime.Now}] url: {Url.Action()}, method: GetAll finished. Request: Responce");

            return Ok();
        }
    }
}
