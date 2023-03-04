using FoodManagerApi.Models;

namespace FoodManagerApi.Services;

public interface IMealService
{
    Task<MealDto> Create(MealDto dto);
    Task<MealDto> Update(MealDto dto);
    Task Delete(MealDto dto);
    Task<MealDto> GetById(Guid mealId);
    Task<IEnumerable<MealDto>> GetAll();
}
