using System.ComponentModel.DataAnnotations;

namespace DAL.Models;
public class Meal
{
    public Guid Id { get; set; }

    [Required]
    public DateTime Date { get; set; }

    [Required]
    public int ServingAmount { get; set; }

    [Required]
    public Guid ProductId { get; set; }

    public virtual Product? Product { get; set; }
}
