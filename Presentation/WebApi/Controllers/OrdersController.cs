using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/v{version:ApiVersion}/orders")]
    public class OrdersController(ILogger<OrdersController> logger) : ApiBaseController
    {
        [HttpGet("{userId:long}")]
        public async Task<IActionResult> GetAll(long userId) 
        {
            logger.LogInformation($"[{DateTime.Now}] url: {Url.Action()}, method: GetAll started. Request:");
            ///service
            logger.LogInformation($"[{DateTime.Now}] url: {Url.Action()}, method: GetAll finished. Request: Responce");

            return Ok();
        }

        [HttpGet("{orderId:long}")]
        public async Task<IActionResult> GetById(long orderId) 
        {
            logger.LogInformation($"[{DateTime.Now}] url: {Url.Action()}, method: GetAll started. Request:");
            ///service
            logger.LogInformation($"[{DateTime.Now}] url: {Url.Action()}, method: GetAll finished. Request: Responce");

            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Create() 
        {
            logger.LogInformation($"[{DateTime.Now}] url: {Url.Action()}, method: GetAll started. Request:");
            ///service
            logger.LogInformation($"[{DateTime.Now}] url: {Url.Action()}, method: GetAll finished. Request: Responce");

            return Ok();
        }

        [HttpPut("{orderId:long}")]
        public async Task<IActionResult> Update(long orderId)
        {
            logger.LogInformation($"[{DateTime.Now}] url: {Url.Action()}, method: GetAll started. Request:");
            ///service
            logger.LogInformation($"[{DateTime.Now}] url: {Url.Action()}, method: GetAll finished. Request: Responce");

            return Ok();
        }
    }
}
