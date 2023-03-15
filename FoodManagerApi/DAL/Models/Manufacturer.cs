using System.ComponentModel.DataAnnotations;

namespace DAL.Models;

public class Manufacturer
{
    public Guid Id { get; set; }

    [Required]
    public string? Title { get; set; }

    [Required]
    public string? Country { get; set; }

    public string? Address { get; set; }
}
