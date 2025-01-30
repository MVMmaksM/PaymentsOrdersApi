using Application.Interfaces;
using Application.Interfaces.Repository;
using Application.Mappers.Categories;
using Application.Models.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class CategoryService(ICategoryRepository categoryRepository) : ICategoryService
    {
        public async Task<List<CategoryDto>> GetAll()
        {
            var categoriesEntity = await categoryRepository.GetAll();
            return categoriesEntity.Select(c => c.ToDto())
                .ToList();
        }

        public async Task<CategoryDto> GetById(long id)
        {
            var categoryEntity = await categoryRepository.GetById(id);
            return categoryEntity.ToDto();
        }
    }
}
