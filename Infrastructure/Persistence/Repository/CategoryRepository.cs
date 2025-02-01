using Application.Interfaces.Repository;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Distributed;
using Persistence.Database;
using Newtonsoft.Json;
using Persistence.Cache;

namespace Persistence.Repository
{
    public class CategoryRepository(AppDbContext dbContext, IDistributedCache cache) : ICategoryRepository
    {
        private const string _categoriesKey = "categories";
        private const string _categoryKey = "category";
        public async Task<List<CategoryEntity>?> GetAll()
        {
            var categories = await cache.GetAsync<List<CategoryEntity>>(_categoriesKey);
            if (categories != null)
                return categories;

            categories = await dbContext.Categories.ToListAsync();
            if (categories != null)
                await cache.SetAsync<List<CategoryEntity>>(_categoriesKey, categories);

            return categories;
        }

        public async Task<CategoryEntity?> GetById(long id)
        {
            var category = await cache.GetAsync<CategoryEntity>($"{_categoryKey}:{id}");
            if (category != null)
                return category;

            category = await dbContext.Categories.FirstOrDefaultAsync(c => c.Id == id);
            if (category != null)
                await cache.SetAsync<CategoryEntity>($"{_categoryKey}:{id}", category);

            return category;
        }
    }
}
