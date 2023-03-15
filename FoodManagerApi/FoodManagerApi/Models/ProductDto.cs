using System.ComponentModel.DataAnnotations;

namespace FoodManagerApi.Models;
public class ProductDto
{
    public Guid Id { get; set; }

    [Required(ErrorMessage = "Title is required.")]
    public string? Title { get; set; }

    [Required(ErrorMessage = "Description is required.")]
    public string? Description { get; set; }

    [Required(ErrorMessage = "Composition is required.")]
    public string? Composition { get; set; }

    [Required(ErrorMessage = "NutritionalValueId is required.")]
    public Guid NutritionalValueId { get; set; }

    [Required(ErrorMessage = "ManufacturerId is required.")]
    public Guid ManufacturerId { get; set; }

    public NutritionalValueDto? NutritionalValue { get; set; }

    public ManufacturerDto? Manufacturer { get; set; }
}
