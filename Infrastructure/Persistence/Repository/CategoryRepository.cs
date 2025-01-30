using Application.Interfaces.Repository;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repository
{
    public class CategoryRepository(AppDbContext dbContext) : ICategoryRepository
    {
        public async Task<List<CategoryEntity>> GetAll() 
            => await dbContext.Categories.ToListAsync();

        public async Task<CategoryEntity> GetById(long id)
            => await dbContext.Categories.FirstOrDefaultAsync(c => c.Id == id);
    }
}
