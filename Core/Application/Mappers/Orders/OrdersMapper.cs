using Application.Models.Orders;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappers.Orders
{
    public static class OrdersMapper
    {
        public static OrderDto ToDto(this OrdersEntity ordersEntity) 
        {
            return new OrderDto
            {
                Products = ordersEntity.Products,
                Price = ordersEntity.Price
            };
        }

        public static OrdersEntity ToEntity(this CreateOrdersDto createOrdersDto) 
        {
            return new OrdersEntity
            {
                Products = createOrdersDto.ProductsIds.Select(productId => new ProductEntity 
                {
                    Id = productId
                }).ToList()
            };
        }
    }
}
