using Application.Interfaces.Repository;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Database;

namespace Persistence.Repository
{
    public class OrderRepository(AppDbContext dbContext) : IOrdersRepository
    {
        public async Task<OrdersEntity> Create(OrdersEntity createOrder)
        {
            dbContext.Orders.Add(createOrder);
            await dbContext.SaveChangesAsync();
            return createOrder;
        }

        public async Task<List<OrdersEntity>> GetAll(long userId)
            => await dbContext.Orders.ToListAsync();

        public async Task<OrdersEntity> GetById(long id)
            => await dbContext.Orders.FirstOrDefaultAsync(o => o.Id == id);

        public async Task<OrdersEntity> Update(OrdersEntity updateOrders)
        {
            var updatedOrdersEntity = await dbContext
                .Orders
                .FirstOrDefaultAsync(o => o.Id == updateOrders.Id);

            updatedOrdersEntity.Price = updateOrders.Price;
            updatedOrdersEntity.Products = updateOrders.Products;

            dbContext.Update(updatedOrdersEntity);    
            await dbContext.SaveChangesAsync();

            return updatedOrdersEntity;
        }
    }
}
