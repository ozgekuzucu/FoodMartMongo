using FoodMartMongo.Dtos.ProductDtos;

namespace FoodMartMongo.Services.ProductServices
{
	public class ProductService : IProductService
	{
		public Task CreateProductAsync(CreateProductDto createProductDto)
		{
			throw new NotImplementedException();
		}

		public Task DeleteProductAsync(string id)
		{
			throw new NotImplementedException();
		}

		public Task<List<ResultProductDto>> GetAllProductsAsync()
		{
			throw new NotImplementedException();
		}

		public Task<GetProductByIdDto> GetProductByIdAsync(string id)
		{
			throw new NotImplementedException();
		}

		public Task UpdateProductAsync(UpdateProductDto updateProductDto)
		{
			throw new NotImplementedException();
		}
	}
}
