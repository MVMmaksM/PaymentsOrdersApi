using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Repository
{
    public interface IManufacturerRepository
    {
        Task<List<ManufacturerEntity>> GetAll();
        Task<ManufacturerEntity> GetById(long id);
    }
}
