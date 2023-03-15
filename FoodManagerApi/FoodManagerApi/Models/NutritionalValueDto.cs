using System.ComponentModel.DataAnnotations;

namespace FoodManagerApi.Models;
public class NutritionalValueDto
{
    public Guid Id { get; set; }

    [Required(ErrorMessage = "EnergyValueCalories is required.")]
    public double EnergyValueCalories { get; set; }

    [Required(ErrorMessage = "EnergyValueJoules is required.")]
    public double EnergyValueJoules { get; set; }

    [Required(ErrorMessage = "Fats is required.")]
    public double Fats { get; set; }

    [Required(ErrorMessage = "Proteins is required.")]
    public double Proteins { get; set; }

    [Required(ErrorMessage = "Carbohydrates is required.")]
    public double Carbohydrates { get; set; }

    [Required(ErrorMessage = "Quantity is required.")]
    public int Quantity { get; set; }
}
