using Application.Interfaces;
using Application.Interfaces.Repository;
using Application.Mappers.Orders;
using Application.Models.Orders;

namespace Application.Services
{
    public class OrderService(IOrdersRepository ordersRepository, IProductRespository productRespository) : IOrderService
    {
        public async Task<OrderDto> Create(CreateOrdersDto createOrdersDto)
        {
            var createdOrderEntity = createOrdersDto.ToEntity();

            var productsEntities = await productRespository
                .GetByIds(createOrdersDto.ProductsIds);

            var priceOrders = productsEntities
                .Sum(p => p.Price);

            createdOrderEntity.Price = priceOrders;
            createdOrderEntity.Products = productsEntities;

            var createdOrdersEntity = await ordersRepository.Create(createdOrderEntity);
            return createdOrdersEntity.ToDto();
        }

        public Task<List<OrderDto>> GetAll(long userId)
        {
            throw new NotImplementedException();
        }

        public async Task<OrderDto> GetById(long id)
        {
            var orderEntity = await ordersRepository.GetById(id);
            return orderEntity.ToDto();
        }      

        public Task<OrderDto> Update(long id)
        {
            throw new NotImplementedException();
        }
    }
}
