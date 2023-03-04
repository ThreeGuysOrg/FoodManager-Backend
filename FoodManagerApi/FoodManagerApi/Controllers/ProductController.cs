using FoodManagerApi.Models;
using FoodManagerApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace FoodManagerApi.Controllers;

[Route("[controller]/[action]")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly IProductService _productService;
    public ProductController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetProductById(Guid id)
    {
        var product = await _productService.GetById(id);

        return Ok(product);
    }

    [HttpPut]
    public async Task<IActionResult> UpdateProduct([FromBody] ProductDto dto)
    {
        var updatedProduct = await _productService.Update(dto);

        return Ok(updatedProduct);
    }

    [HttpPost]
    public async Task<IActionResult> CreateProduct([FromBody] ProductDto dto)
    {
        var createdProduct = await _productService.Create(dto);

        return Ok(createdProduct);
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteProduct([FromBody] ProductDto dto)
    {
        await _productService.Delete(dto);

        return Ok("Product was deleted");
    }
}
