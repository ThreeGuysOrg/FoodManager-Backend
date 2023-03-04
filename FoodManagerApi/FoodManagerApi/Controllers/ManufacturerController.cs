using FoodManagerApi.Models;
using FoodManagerApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace FoodManagerApi.Controllers;

[Route("[controller]/[action]")]
[ApiController]
public class ManufacturerController : ControllerBase
{
    private readonly IManufacturerService _manufacturerService;
    public ManufacturerController(IManufacturerService manufacturerService)
    {
        _manufacturerService = manufacturerService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllManufacturers()
    {
        var manufacturers = await _manufacturerService.GetAll();

        return Ok(manufacturers);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetManufacturerById(Guid id)
    {
        var manufacturer = await _manufacturerService.GetById(id);

        return Ok(manufacturer);
    }

    [HttpPut]
    public async Task<IActionResult> UpdateManufacturer([FromBody] ManufacturerDto dto)
    {
        var updatedManufacturer = await _manufacturerService.Update(dto);

        return Ok(updatedManufacturer);
    }

    [HttpPost]
    public async Task<IActionResult> CreateManufacturer([FromBody] ManufacturerDto dto)
    {
        var createdManufacturer = await _manufacturerService.Create(dto);

        return Ok(createdManufacturer);
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteManufacturer([FromBody] ManufacturerDto dto)
    {
        await _manufacturerService.Delete(dto);

        return Ok("Manufacturer was deleted");
    }
}
