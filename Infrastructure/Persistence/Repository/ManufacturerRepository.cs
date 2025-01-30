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
    public class ManufacturerRepository(AppDbContext dbContext) : IManufacturerRepository
    {
        public async Task<List<ManufacturerEntity>> GetAll()
            => await dbContext.Manufacturers.ToListAsync();

        public async Task<ManufacturerEntity> GetById(long id)
            => await dbContext.Manufacturers.FirstOrDefaultAsync(m => m.Id == id);
    }
}
