using Application.Interfaces;
using Application.Models.Orders;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/v{version:ApiVersion}/orders")]
    public class OrdersController(IOrderService orderService) : ApiBaseController
    {  
        [HttpGet("{orderId:long}")]
        public async Task<IActionResult> GetById(long orderId)
        {
            var order = await orderService.GetById(orderId);
            return Ok(order);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateOrdersDto createOrdersDto)
        {
            var createdOrder = await orderService.Create(createOrdersDto);
            return Ok(createdOrder);
        }

        [HttpPut("{orderId:long}")]
        public async Task<IActionResult> Update(long orderId)
        {           
            return Ok();
        }
    }
}
