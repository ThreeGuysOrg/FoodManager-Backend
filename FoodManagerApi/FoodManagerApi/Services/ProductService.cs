using DAL.Models;
using DAL.Repositories;
using FoodManagerApi.Extensions;
using FoodManagerApi.Models;

namespace FoodManagerApi.Services;

public class ProductService : IProductService
{
    private readonly IEntityRepository<Product> _productRepo;

    public ProductService(IEntityRepository<Product> productRepo)
    {
        _productRepo = productRepo;
    }
    public async Task<ProductDto> Create(ProductDto dto)
    {
        var createdProduct = await _productRepo.Create(dto.ToDomain());

        return createdProduct.ToModel();
    }

    public async Task Delete(ProductDto dto)
    {
        await _productRepo.Delete(dto.ToDomain()).ConfigureAwait(false);
    }

    public async Task<IEnumerable<ProductDto>> GetAll()
    {
        var products = await _productRepo.GetAll();

        return products.Select(product => product.ToModel()).ToList();
    }

    public async Task<ProductDto> GetById(Guid mealId)
    {
        var product = await _productRepo.GetById(mealId);

        return product.ToModel();
    }

    public async Task<ProductDto> Update(ProductDto dto)
    {
        var updatedProduct = await _productRepo.Update(dto.ToDomain());

        return updatedProduct.ToModel();
    }
}
