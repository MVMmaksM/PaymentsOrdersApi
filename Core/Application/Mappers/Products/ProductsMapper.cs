using Application.Models.Products;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappers.Products
{
    public static class ProductsMapper
    {
        public static ProductsDto ToDto(this ProductEntity productEntity)
        {
            return new ProductsDto
            {
                Id = productEntity.Id,
                Name = productEntity.Name,
                CategoryId = productEntity.CategoryId,
                Price = productEntity.Price
            };
        }
    }
}
