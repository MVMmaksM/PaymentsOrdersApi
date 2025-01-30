using Application.Models.Orders;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Application.Mappers.Orders
{
    public static class OrdersMapper
    {
        public static OrderDto ToDto(this OrdersEntity ordersEntity) 
        {
            return new OrderDto
            {
                Products = ordersEntity.Products.Select(p => new Models.Products.ProductsDto 
                { 
                    Id = p.Id,
                    Name = p.Name,
                    CategoryId = p.CategoryId,
                    Price = p.Price
                }).ToList(),

                TotalCost = ordersEntity.Price,
                CreateAt = ordersEntity.CreatedAt,
                Id = ordersEntity.Id
            };
        }

        public static OrdersEntity ToEntity(this CreateOrdersDto createOrdersDto) 
        {
            return new OrdersEntity();
        }
    }
}
