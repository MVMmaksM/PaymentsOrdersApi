using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace WebApi.Controllers
{
    [Route("api/v{version:apiVersion}/sellers")]
    public class SellersController(ILogger<SellersController> logger) : ApiBaseController
    {
        [HttpGet]
        public async Task<IActionResult> GetAll(ApiVersion apiVersion) 
        {
            logger.LogInformation($"[{DateTime.Now}] url: {Url.Action()}, method: GetAll started. Request:");
            ///service
            logger.LogInformation($"[{DateTime.Now}] url: {Url.Action()}, method: GetAll finished. Request: Responce");

            return Ok();
        }

        [HttpGet("{sellerId:long}")]
        public async Task<IActionResult> GetById(ApiVersion apiVersion, long sellerId) 
        {
            logger.LogInformation($"[{DateTime.Now}] url: {Url.Action()}, method: GetById started");
            ///service
            logger.LogInformation($"[{DateTime.Now}] url: {Url.Action()}, method: GetById finished. Responce");

            return Ok();
        }
    }
}
