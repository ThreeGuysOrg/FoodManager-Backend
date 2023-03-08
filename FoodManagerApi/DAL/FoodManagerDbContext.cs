using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL;
public class FoodManagerDbContext : DbContext
{
    public FoodManagerDbContext(DbContextOptions<FoodManagerDbContext> options)
            : base(options)
    {
    }
    public DbSet<NutritionalValue> NutritionalValues { get; set; }
    public DbSet<Meal> Meals { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Manufacturer> Manufacturers { get; set; }
    public DbSet<User> Users { get; set; }
}
