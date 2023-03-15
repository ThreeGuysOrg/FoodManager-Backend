using System.ComponentModel.DataAnnotations;

namespace DAL.Models;

public class Product
{
    public Guid Id { get; set; }

    [Required]
    public string? Title { get; set; }

    [Required]
    public string? Description { get; set; }

    [Required]
    public string? Composition { get; set; }

    [Required]
    public Guid NutritionalValueId { get; set; }

    [Required]
    public Guid ManufacturerId { get; set; }
    public virtual NutritionalValue? NutritionalValue { get; set; }
    public virtual Manufacturer? Manufacturer { get; set; }
}
