using DAL.Models;
using DAL.Repositories;
using FoodManagerApi.Extensions;
using FoodManagerApi.Models;

namespace FoodManagerApi.Services;

public class ManufacturerService : IManufacturerService
{
    private readonly IEntityRepository<Manufacturer> _manufacturerRepo;

    public ManufacturerService(IEntityRepository<Manufacturer> manufacturerRepo)
    {
        _manufacturerRepo = manufacturerRepo;
    }
    public async Task<ManufacturerDto> Create(ManufacturerDto dto)
    {
        var createdManufacturer = await _manufacturerRepo.Create(dto.ToDomain());

        return createdManufacturer.ToModel();
    }

    public async Task Delete(ManufacturerDto dto)
    {
        await _manufacturerRepo.Delete(dto.ToDomain()).ConfigureAwait(false);
    }

    public async Task<IEnumerable<ManufacturerDto>> GetAll()
    {
        var manufacturers = await _manufacturerRepo.GetAll();

        return manufacturers.Select(manufacturer => manufacturer.ToModel()).ToList();
    }

    public async Task<ManufacturerDto> GetById(Guid characterId)
    {
        var manufacturer = await _manufacturerRepo.GetById(characterId);

        return manufacturer.ToModel();
    }

    public async Task<ManufacturerDto> Update(ManufacturerDto dto)
    {
        var updatedManufacturer = await _manufacturerRepo.Update(dto.ToDomain());

        return updatedManufacturer.ToModel();
    }
}
