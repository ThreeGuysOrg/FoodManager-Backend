using DAL.Models;
using FoodManagerApi.Models;
using AutoMapper;

namespace FoodManagerApi.Extensions;

public static class MappingExtensions
{
    #region ToModel
    public static UserDto ToModel(this User user)
    {
        return Mapper<User, UserDto>(user, cfg =>
        {
            cfg.CreateMap<User, UserDto>()
             .ForMember(dest => dest.Name, opt => opt.MapFrom(c => c.Name))
             .ForMember(dest => dest.LastName, opt => opt.MapFrom(c => c.LastName))
             .ForMember(dest => dest.Login, opt => opt.MapFrom(c => c.Email))
             .ForMember(dest => dest.Phone, opt => opt.MapFrom(c => c.Phone));
        });
    }

    public static ManufacturerDto ToModel(this Manufacturer manufacturer)
    {
        return Mapper<Manufacturer, ManufacturerDto>(manufacturer, cfg =>
        {
            cfg.CreateMap<Manufacturer, ManufacturerDto>()
             .ForMember(dest => dest.Id, opt => opt.MapFrom(c => c.Id))
             .ForMember(dest => dest.Title, opt => opt.MapFrom(c => c.Title))
             .ForMember(dest => dest.Address, opt => opt.MapFrom(c => c.Address))
             .ForMember(dest => dest.Country, opt => opt.MapFrom(c => c.Country));
        });
    }

    public static MealDto ToModel(this Meal meal)
    {
        return Mapper<Meal, MealDto>(meal, cfg =>
        {
            cfg.CreateMap<Meal, MealDto>()
             .ForMember(dest => dest.Id, opt => opt.MapFrom(c => c.Id))
             .ForMember(dest => dest.Date, opt => opt.MapFrom(c => c.Date))
             .ForMember(dest => dest.ServingAmount, opt => opt.MapFrom(c => c.ServingAmount))
             .ForMember(dest => dest.ProductId, opt => opt.MapFrom(c => c.ProductId))
             .ForMember(dest => dest.Product, opt => opt.MapFrom(c => c.Product));
        });
    }

    public static NutritionalValueDto ToModel(this NutritionalValue nutritionalValue)
    {
        return Mapper<NutritionalValue, NutritionalValueDto>(nutritionalValue, cfg =>
        {
            cfg.CreateMap<NutritionalValue, NutritionalValueDto>()
             .ForMember(dest => dest.Id, opt => opt.MapFrom(c => c.Id))
             .ForMember(dest => dest.EnergyValueCalories, opt => opt.MapFrom(c => c.EnergyValueCalories))
             .ForMember(dest => dest.EnergyValueJoules, opt => opt.MapFrom(c => c.EnergyValueJoules))
             .ForMember(dest => dest.Fats, opt => opt.MapFrom(c => c.Fats))
             .ForMember(dest => dest.Proteins, opt => opt.MapFrom(c => c.Proteins))
             .ForMember(dest => dest.Carbohydrates, opt => opt.MapFrom(c => c.Carbohydrates))
             .ForMember(dest => dest.Quantity, opt => opt.MapFrom(c => c.Quantity));
        });
    }

    public static ProductDto ToModel(this Product product)
    {
        return Mapper<Product, ProductDto>(product, cfg =>
        {
            cfg.CreateMap<Product, ProductDto>()
             .ForMember(dest => dest.Id, opt => opt.MapFrom(c => c.Id))
             .ForMember(dest => dest.Title, opt => opt.MapFrom(c => c.Title))
             .ForMember(dest => dest.Description, opt => opt.MapFrom(c => c.Description))
             .ForMember(dest => dest.Composition, opt => opt.MapFrom(c => c.Composition))
             .ForMember(dest => dest.NutritionalValueId, opt => opt.MapFrom(c => c.NutritionalValueId))
             .ForMember(dest => dest.ManufacturerId, opt => opt.MapFrom(c => c.ManufacturerId))
             .ForMember(dest => dest.NutritionalValue, opt => opt.MapFrom(c => c.NutritionalValue))
             .ForMember(dest => dest.Manufacturer, opt => opt.MapFrom(c => c.Manufacturer));
        });
    }
    #endregion

    #region ToDomain
    public static User ToDomain(this UserDto dto)
    {
        return Mapper<UserDto, User>(dto, cfg =>
        {
            cfg.CreateMap<UserDto, User>()
             .ForMember(dest => dest.Name, opt => opt.MapFrom(c => c.Name))
             .ForMember(dest => dest.LastName, opt => opt.MapFrom(c => c.LastName))
             .ForMember(dest => dest.Email, opt => opt.MapFrom(c => c.Login))
             .ForMember(dest => dest.Phone, opt => opt.MapFrom(c => c.Phone));
        });
    }

    public static Manufacturer ToDomain(this ManufacturerDto dto)
    {
        return Mapper<ManufacturerDto, Manufacturer>(dto, cfg =>
        {
            cfg.CreateMap<ManufacturerDto, Manufacturer>()
             .ForMember(dest => dest.Id, opt => opt.MapFrom(c => c.Id))
             .ForMember(dest => dest.Title, opt => opt.MapFrom(c => c.Title))
             .ForMember(dest => dest.Address, opt => opt.MapFrom(c => c.Address))
             .ForMember(dest => dest.Country, opt => opt.MapFrom(c => c.Country));
        });
    }

    public static Meal ToDomain(this MealDto dto)
    {
        return Mapper<MealDto, Meal>(dto, cfg =>
        {
            cfg.CreateMap<MealDto, Meal>()
             .ForMember(dest => dest.Id, opt => opt.MapFrom(c => c.Id))
             .ForMember(dest => dest.Date, opt => opt.MapFrom(c => c.Date))
             .ForMember(dest => dest.ServingAmount, opt => opt.MapFrom(c => c.ServingAmount))
             .ForMember(dest => dest.ProductId, opt => opt.MapFrom(c => c.ProductId))
             .ForMember(dest => dest.Product, opt => opt.Ignore());
        });
    }

    public static NutritionalValue ToDomain(this NutritionalValueDto dto)
    {
        return Mapper<NutritionalValueDto, NutritionalValue>(dto, cfg =>
        {
            cfg.CreateMap<NutritionalValueDto, NutritionalValue>()
             .ForMember(dest => dest.Id, opt => opt.MapFrom(c => c.Id))
             .ForMember(dest => dest.EnergyValueCalories, opt => opt.MapFrom(c => c.EnergyValueCalories))
             .ForMember(dest => dest.EnergyValueJoules, opt => opt.MapFrom(c => c.EnergyValueJoules))
             .ForMember(dest => dest.Fats, opt => opt.MapFrom(c => c.Fats))
             .ForMember(dest => dest.Proteins, opt => opt.MapFrom(c => c.Proteins))
             .ForMember(dest => dest.Carbohydrates, opt => opt.MapFrom(c => c.Carbohydrates))
             .ForMember(dest => dest.Quantity, opt => opt.MapFrom(c => c.Quantity));
        });
    }

    public static Product ToDomain(this ProductDto dto)
    {
        return Mapper<ProductDto, Product>(dto, cfg =>
        {
            cfg.CreateMap<ProductDto, Product>()
             .ForMember(dest => dest.Id, opt => opt.MapFrom(c => c.Id))
             .ForMember(dest => dest.Title, opt => opt.MapFrom(c => c.Title))
             .ForMember(dest => dest.Description, opt => opt.MapFrom(c => c.Description))
             .ForMember(dest => dest.Composition, opt => opt.MapFrom(c => c.Composition))
             .ForMember(dest => dest.NutritionalValueId, opt => opt.MapFrom(c => c.NutritionalValueId))
             .ForMember(dest => dest.ManufacturerId, opt => opt.MapFrom(c => c.ManufacturerId))
             .ForMember(dest => dest.NutritionalValue, opt => opt.Ignore())
             .ForMember(dest => dest.Manufacturer, opt => opt.Ignore());
        });
    }

    #endregion

    private static TDestination Mapper<TSource, TDestination>(
            this TSource source,
            Action<IMapperConfigurationExpression> configure)
    {
        var config = new MapperConfiguration(configure);
        var mapper = config.CreateMapper();
        var destination = mapper.Map<TDestination>(source);
        return destination;
    }
}
