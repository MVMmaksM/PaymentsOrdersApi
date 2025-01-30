using Application.Interfaces;
using Application.Interfaces.Repository;
using Application.Mappers.Manufacturers;
using Application.Models.Manufacturers;

namespace Application.Services
{
    public class ManufacturerService(IManufacturerRepository manufacturerRepository) : IManufacturerService
    {
        public async Task<List<ManufacturerDto>> GetAll()
        {
            var manufacturerEntites = await manufacturerRepository.GetAll();
            return manufacturerEntites
                .Select(m => m.ToDto())
                .ToList();
        }

        public async Task<ManufacturerDto> GetById(long id)
        {
            var manufacturerEntity = await manufacturerRepository.GetById(id);
            return manufacturerEntity.ToDto();
        }
    }
}
