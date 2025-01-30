using Application.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IOrderService
    {
        Task<List<OrderDto>> GetAll(long userId);
        Task<OrderDto> GetById(long id);
        Task<OrderDto> Create(CreateOrdersDto createOrdersDto);
        Task<OrderDto> Update(long id);
    }
}
