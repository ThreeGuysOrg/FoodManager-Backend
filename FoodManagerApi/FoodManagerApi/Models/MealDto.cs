namespace FoodManagerApi.Models;
public class MealDto
{
    public Guid Id { get; set; }
    public DateTime Date { get; set; }
    public int ServingAmount { get; set; }
    public Guid ProductId { get; set; }
    public ProductDto Product { get; set; }
}
