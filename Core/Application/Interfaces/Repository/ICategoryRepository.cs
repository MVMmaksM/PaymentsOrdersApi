using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Repository
{
    public interface ICategoryRepository
    {
        Task<List<CategoryEntity>?> GetAll();
        Task<CategoryEntity?> GetById(long id);
    }
}
