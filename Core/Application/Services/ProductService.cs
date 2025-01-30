using Application.Interfaces;
using Application.Interfaces.Repository;
using Application.Mappers.Products;
using Application.Models.Products;

namespace Application.Services
{
    public class ProductService(IProductRespository productRespository) : IProductService
    {
        public async Task<List<ProductsDto>> GetAll()
        {
            var productsEntities = await productRespository.GetAll();
            return productsEntities
                .Select(p => p.ToDto())
                .ToList();
        }

        public async Task<ProductsDto> GetById(long id)
        {
            var productEntity = await productRespository.GetById(id);
            return productEntity.ToDto();
        }
    }
}
