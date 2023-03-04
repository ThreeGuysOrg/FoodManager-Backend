using FoodManagerApi.Models;
using FoodManagerApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FoodManagerApi.Controllers;

[Route("[controller]/[action]")]
[ApiController]
public class MealController : ControllerBase
{
    private readonly IMealService _mealService;
    public MealController(IMealService mealService)
    {
        _mealService = mealService;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetMealById(Guid id)
    {
        var meal = await _mealService.GetById(id);

        return Ok(meal);
    }

    [HttpPut]
    public async Task<IActionResult> UpdateMeal([FromBody] MealDto dto)
    {
        var updatedMeal = await _mealService.Update(dto);

        return Ok(updatedMeal);
    }

    [HttpPost]
    public async Task<IActionResult> CreateMeal([FromBody] MealDto dto)
    {
        var createdMeal = await _mealService.Create(dto);

        return Ok(createdMeal);
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteMeal([FromBody] MealDto dto)
    {
        await _mealService.Delete(dto);

        return Ok("Meal was deleted");
    }
}
