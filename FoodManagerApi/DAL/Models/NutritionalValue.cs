using System.ComponentModel.DataAnnotations;

namespace DAL.Models;
public class NutritionalValue
{
    public Guid Id { get; set; }

    [Required]
    public double EnergyValueCalories { get; set; }

    [Required]
    public double EnergyValueJoules { get; set; }

    [Required]
    public double Fats { get; set; }

    [Required]
    public double Proteins { get; set; }

    [Required]
    public double Carbohydrates { get; set; }

    [Required]
    public int Quantity { get; set; }
}
