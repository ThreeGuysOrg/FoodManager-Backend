using DAL;
using DAL.Models;
using DAL.Repositories;
using FoodManagerApi.Services;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddDbContext<FoodManagerDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration["ConnectionStrings:MSSQLConnection"]);
});

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// Services
builder.Services.AddTransient<IManufacturerService, ManufacturerService>();
builder.Services.AddTransient<IMealService, MealService>();
builder.Services.AddTransient<IProductService, ProductService>();
builder.Services.AddTransient<INutritionalValueService, NutritionalValueService>();

// Repositories
builder.Services.AddTransient<IEntityRepository<Manufacturer>, EntityRepository<Manufacturer>>();
builder.Services.AddTransient<IEntityRepository<Meal>, EntityRepository<Meal>>();
builder.Services.AddTransient<IEntityRepository<Product>, EntityRepository<Product>>();
builder.Services.AddTransient<IEntityRepository<NutritionalValue>, EntityRepository<NutritionalValue>>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
