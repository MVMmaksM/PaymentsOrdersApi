using Application.Interfaces;
using Application.Interfaces.Repository;
using Application.Mappers.Sellers;
using Application.Models.Sellers;

namespace Application.Services
{
    public class SellerService(ISellerRepository sellerRepository) : ISellerService
    {
        public async Task<List<SellersDto>> GetAll()
        {
            var sellerEntites = await sellerRepository.GetAll();
            return sellerEntites
                .Select(s => s.ToDto())
                .ToList();
        }

        public async Task<SellersDto> GetById(long id)
        {
            var sellerEntity = await sellerRepository.GetById(id);
            return sellerEntity.ToDto();
        }
    }
}
