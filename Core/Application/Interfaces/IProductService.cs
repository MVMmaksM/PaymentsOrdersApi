using Application.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IProductService
    {
        Task<List<ProductsDto>> GetAll();
        Task<ProductsDto> GetById(long id);
    }
}
