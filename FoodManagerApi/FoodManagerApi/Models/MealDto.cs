using System.ComponentModel.DataAnnotations;

namespace FoodManagerApi.Models;
public class MealDto
{
    private const int MinServingAmount = 1;
    private const int MaxServingAmount = 100;
    public Guid Id { get; set; }

    [Required(ErrorMessage = "Date is required.")]
    public DateTime Date { get; set; }

    [Required(ErrorMessage = "ServingAmount is required.")]
    [Range(MinServingAmount, MaxServingAmount)]
    public int ServingAmount { get; set; }

    [Required(ErrorMessage = "ProductId is required.")]
    public Guid ProductId { get; set; }

    public ProductDto? Product { get; set; }
}
