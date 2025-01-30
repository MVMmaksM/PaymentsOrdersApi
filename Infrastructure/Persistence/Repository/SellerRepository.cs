using Application.Interfaces.Repository;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Database;

namespace Persistence.Repository
{
    public class SellerRepository(AppDbContext dbContext) : ISellerRepository
    {
        public async Task<List<SellerEntity>> GetAll()
            => await dbContext.Sellers.ToListAsync();

        public async Task<SellerEntity> GetById(long id)
            => await dbContext.Sellers.FirstOrDefaultAsync(s => s.Id == id);      
    }
}
