using Application.Models.Sellers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface ISellerService
    {
        Task<List<SellersDto>> GetAll();
        Task<SellersDto> GetById(long id);
    }
}
