using FoodManagerApi.Models;

namespace FoodManagerApi.Services;

public interface INutritionalValueService
{
    Task<NutritionalValueDto> Create(NutritionalValueDto dto);
    Task<NutritionalValueDto> Update(NutritionalValueDto dto);
    Task Delete(NutritionalValueDto dto);
    Task<NutritionalValueDto> GetById(Guid nutritionalValueId);
    Task<IEnumerable<NutritionalValueDto>> GetAll();
}
