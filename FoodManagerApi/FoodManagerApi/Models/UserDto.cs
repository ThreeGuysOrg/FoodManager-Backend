using System.ComponentModel.DataAnnotations;

namespace FoodManagerApi.Models;
public class UserDto
{
    public string? Name { get; set; }

    public string? LastName { get; set; }

    [Phone]
    public string? Phone { get; set; }

    [Required(ErrorMessage = "Login is required.")]
    [EmailAddress]
    public string? Login { get; set; }

    [Required(ErrorMessage = "Password is required.")]
    public string? Password { get; set; }
}
