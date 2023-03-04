using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models;

public class Product
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Composition { get; set; }
    public Guid NutritionalValueId { get; set; }
    public Guid ManufacturerId { get; set; }
    public virtual NutritionalValue NutritionalValue { get; set; }
    public virtual Manufacturer Manufacturer { get; set; }
}
