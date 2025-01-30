using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Repository
{
    public interface IOrdersRepository
    {
        Task<List<OrdersEntity>> GetAll(long userId);
        Task<OrdersEntity> GetById(long id);
        Task<OrdersEntity> Create(OrdersEntity createOrder);
        Task<OrdersEntity> Update(OrdersEntity updateOrders);
    }
}
