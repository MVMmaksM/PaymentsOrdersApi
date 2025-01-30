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
    public class ProductRepository(AppDbContext dbContext) : IProductRespository
    {
        public async Task<List<ProductEntity>> GetAll()
            => await dbContext
            .Products
            .Include(p => p.Manufacturers)
            .Include(p => p.Sellers)
            .ToListAsync();

        public async Task<ProductEntity> GetById(long id)
            => await dbContext.Products.FirstOrDefaultAsync(p => p.Id == id);

        public async Task<List<ProductEntity>> GetByIds(IEnumerable<long> ids)
            => await dbContext
            .Products            
            .Where(p => ids.Contains(p.Id))
            .ToListAsync();
    }
}
