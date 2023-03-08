namespace FoodManagerApi.Models;
public class ProductDto
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Composition { get; set; }
    public Guid NutritionalValueId { get; set; }
    public Guid ManufacturerId { get; set; }
    public NutritionalValueDto NutritionalValue { get; set; }
    public ManufacturerDto Manufacturer { get; set; }
}
