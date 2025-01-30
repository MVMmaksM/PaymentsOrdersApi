using Application.Models.Sellers;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappers.Sellers
{
    public static class SellersMapper
    {
        public static SellersDto ToDto(this SellerEntity sellerEntity)
        {
            return new SellersDto
            {
                Id = sellerEntity.Id,
                Name = sellerEntity.Name
            };
        }
    }
}
