using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/v{version:ApiVersion}/manufacturers")]
    public class ManufacturersController(ILogger<ManufacturersController> logger) : ApiBaseController
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            logger.LogInformation($"[{DateTime.Now}] url: {Url.Action()}, method: GetAll started. Request:");
            ///service
            logger.LogInformation($"[{DateTime.Now}] url: {Url.Action()}, method: GetAll finished. Request: Responce");

            return Ok();
        }

        [HttpGet("{manufacturerId:long}")]
        public async Task<IActionResult> GetById(long manufacturerId) 
        {
            logger.LogInformation($"[{DateTime.Now}] url: {Url.Action()}, method: GetAll started. Request:");
            ///service
            logger.LogInformation($"[{DateTime.Now}] url: {Url.Action()}, method: GetAll finished. Request: Responce");

            return Ok();
        }
    }
}
