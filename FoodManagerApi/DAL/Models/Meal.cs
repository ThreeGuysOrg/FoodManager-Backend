namespace DAL.Models;
public class Meal
{
    public Guid Id { get; set; }
    public DateTime Date { get; set; }
    public int ServingAmount { get; set; }
    public Guid ProductId { get; set; }
    public virtual Product Product { get; set; }
}
