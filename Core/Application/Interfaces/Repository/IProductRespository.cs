using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Repository
{
    public interface IProductRespository
    {
        Task<List<ProductEntity>> GetAll();
        Task<ProductEntity> GetById(long id);
        Task<List<ProductEntity>> GetByIds(IEnumerable<long> ids);
    }
}
