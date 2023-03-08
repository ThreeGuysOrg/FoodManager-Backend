using FoodManagerApi.Models;

namespace FoodManagerApi.Services;

public interface IManufacturerService
{
    Task<ManufacturerDto> Create(ManufacturerDto dto);
    Task<ManufacturerDto> Update(ManufacturerDto dto);
    Task Delete(ManufacturerDto dto);
    Task<ManufacturerDto> GetById(Guid manufacturerId);
    Task<IEnumerable<ManufacturerDto>> GetAll();
}
