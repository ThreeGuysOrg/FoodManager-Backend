using DAL.Models;
using DAL.Repositories;
using FoodManagerApi.Extensions;
using FoodManagerApi.Models;

namespace FoodManagerApi.Services;

public class NutritionalValueService : INutritionalValueService
{
    private readonly IEntityRepository<NutritionalValue> _nutritionalValueRepo;

    public NutritionalValueService(IEntityRepository<NutritionalValue> nutritionalValueRepo)
    {
        _nutritionalValueRepo = nutritionalValueRepo;
    }
    public async Task<NutritionalValueDto> Create(NutritionalValueDto dto)
    {
        var createdNutritionalValue = await _nutritionalValueRepo.Create(dto.ToDomain());

        return createdNutritionalValue.ToModel();
    }

    public async Task Delete(NutritionalValueDto dto)
    {
        await _nutritionalValueRepo.Delete(dto.ToDomain()).ConfigureAwait(false);
    }

    public async Task<IEnumerable<NutritionalValueDto>> GetAll()
    {
        var nutritionalValues = await _nutritionalValueRepo.GetAll();

        return nutritionalValues.Select(nutritionalValue => nutritionalValue.ToModel()).ToList();
    }

    public async Task<NutritionalValueDto> GetById(Guid nutritionalValueId)
    {
        var nutritionalValue = await _nutritionalValueRepo.GetById(nutritionalValueId);

        return nutritionalValue.ToModel();
    }

    public async Task<NutritionalValueDto> Update(NutritionalValueDto dto)
    {
        var updatedNutritionalValue = await _nutritionalValueRepo.Update(dto.ToDomain());

        return updatedNutritionalValue.ToModel();
    }
}
