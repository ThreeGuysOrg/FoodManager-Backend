using System.ComponentModel.DataAnnotations;

namespace FoodManagerApi.Models;

public class ManufacturerDto
{
    public Guid Id { get; set; }

    [Required(ErrorMessage = "Title is required.")]
    public string? Title { get; set; }

    [Required(ErrorMessage = "Country is required.")]
    public string? Country { get; set; }

    public string? Address { get; set; }
}
