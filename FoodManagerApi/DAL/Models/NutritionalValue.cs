namespace DAL.Models;
public class NutritionalValue
{
    public Guid Id { get; set; }
    public double EnergyValueCalories { get; set; }
    public double EnergyValueJoules { get; set; }
    public double Fats { get; set; }
    public double Proteins { get; set; }
    public double Carbohydrates { get; set; }
    public int Quantity { get; set; }
}
