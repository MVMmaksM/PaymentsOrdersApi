using Application.Models.Category;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappers.Categories
{
    public static class CategoriesMapper
    {
        public static CategoryDto ToDto(this CategoryEntity categoryEntity)
        {
            return new CategoryDto
            {
                Id = categoryEntity.Id,
                Name = categoryEntity.Name
            };
        }
    }
}
