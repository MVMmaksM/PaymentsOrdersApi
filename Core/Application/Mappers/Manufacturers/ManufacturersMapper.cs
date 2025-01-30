using Application.Models.Manufacturers;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappers.Manufacturers
{
    public static class ManufacturersMapper
    {
        public static ManufacturerDto ToDto(this ManufacturerEntity manufacturerEntity)
        {
            return new ManufacturerDto
            {
                Id = manufacturerEntity.Id,
                Name = manufacturerEntity.Name
            };
        }
    }
}
