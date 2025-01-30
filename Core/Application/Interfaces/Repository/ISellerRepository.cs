using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Repository
{
    public interface ISellerRepository
    {

        Task<List<SellerEntity>> GetAll();
        Task<SellerEntity> GetById(long id);
    }
}
