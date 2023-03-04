using FoodManagerApi.Models;

namespace FoodManagerApi.Services;

public interface IProductService
{
    Task<ProductDto> Create(ProductDto dto);
    Task<ProductDto> Update(ProductDto dto);
    Task Delete(ProductDto dto);
    Task<ProductDto> GetById(Guid productId);
    Task<IEnumerable<ProductDto>> GetAll();
}
