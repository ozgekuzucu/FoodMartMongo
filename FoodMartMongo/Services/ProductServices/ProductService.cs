using AutoMapper;
using FoodMartMongo.Dtos.ProductDtos;
using FoodMartMongo.Entities;
using FoodMartMongo.Settings;
using MongoDB.Driver;

namespace FoodMartMongo.Services.ProductServices
{
	public class ProductService : IProductService
	{
		private readonly IMongoCollection<Product> _productCollection;
		private readonly IMapper _mapper;

		public ProductService(IMapper mapper, DatabaseSettings _databaseSettings)
		{
			var client = new MongoClient(_databaseSettings.ConnectionString);
			var database = client.GetDatabase(_databaseSettings.DatabaseName);
			_productCollection = database.GetCollection<Product>(_databaseSettings.ProductCollectionName);
			_mapper = mapper;
		}

		public async Task CreateProductAsync(CreateProductDto createProductDto)
		{
			var value = _mapper.Map<Product>(createProductDto);
			await _productCollection.InsertOneAsync(value);
		}

		public async Task DeleteProductAsync(string id)
		{
			await _productCollection.DeleteOneAsync(x => x.ProductId == id);
		}

		public Task<List<ResultProductDto>> GetAllProductsAsync()
		{
			throw new NotImplementedException();
		}

		public Task<GetProductByIdDto> GetProductByIdAsync(string id)
		{
			throw new NotImplementedException();
		}

		public async Task UpdateProductAsync(UpdateProductDto updateProductDto)
		{
			var values = _mapper.Map<Product>(updateProductDto);
			await _productCollection.FindOneAndReplaceAsync(x => x.ProductId == updateProductDto.ProductId, values);
		}
	}
}
