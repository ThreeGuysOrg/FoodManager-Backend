using DAL.Models;
using DAL.Repositories;
using FoodManagerApi.Extensions;
using FoodManagerApi.Models;

namespace FoodManagerApi.Services;

public class MealService : IMealService
{
    private readonly IEntityRepository<Meal> _mealRepo;

    public MealService(IEntityRepository<Meal> mealRepo)
    {
        _mealRepo = mealRepo;
    }
    public async Task<MealDto> Create(MealDto dto)
    {
        var createdMeal = await _mealRepo.Create(dto.ToDomain());

        return createdMeal.ToModel();
    }

    public async Task Delete(MealDto dto)
    {
        await _mealRepo.Delete(dto.ToDomain()).ConfigureAwait(false);
    }

    public async Task<IEnumerable<MealDto>> GetAll()
    {
        var meals = await _mealRepo.GetAll();

        return meals.Select(meal => meal.ToModel()).ToList();
    }

    public async Task<MealDto> GetById(Guid mealId)
    {
        var meal = await _mealRepo.GetById(mealId);

        return meal.ToModel();
    }

    public async Task<MealDto> Update(MealDto dto)
    {
        var updatedMeal = await _mealRepo.Update(dto.ToDomain());

        return updatedMeal.ToModel();
    }
}
