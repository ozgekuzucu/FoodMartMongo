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
		private readonly IMongoCollection<Category> _categoryCollection;
		private readonly IMapper _mapper;
		public ProductService(IMapper mapper, IDatabaseSettings _databaseSettings)
		{
			var client = new MongoClient(_databaseSettings.ConnectionString);
			var database = client.GetDatabase(_databaseSettings.DatabaseName);
			_productCollection = database.GetCollection<Product>(_databaseSettings.ProductCollectionName);
			_categoryCollection = database.GetCollection<Category>(_databaseSettings.CategoryCollectionName);
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

		public async Task<List<ResultProductDto>> GetAllProductsAsync()
		{
			var values = await _productCollection.Find(x => true).ToListAsync();
			foreach (var item in values)
			{
				item.Category = await _categoryCollection.Find<Category>(x => x.CategoryId == item.CategoryId).FirstAsync();
			}
			return _mapper.Map<List<ResultProductDto>>(values);
		}

		public async Task<List<ResultProductWithCategoryDto>> GetAllProductWithCategoryAsync()
		{
			var values = await _productCollection.Find(x => true).ToListAsync();

			foreach (var item in values)
			{
				item.Category = await _categoryCollection.Find<Category>(x => x.CategoryId == item.CategoryId).FirstAsync();
			}

			return _mapper.Map<List<ResultProductWithCategoryDto>>(values);
		}

		public async Task<GetProductByIdDto> GetProductByIdAsync(string id)
		{
			var value = await _productCollection.Find(x => x.ProductId == id).FirstOrDefaultAsync();
			return _mapper.Map<GetProductByIdDto>(value);
		}

		public async Task UpdateProductAsync(UpdateProductDto updateProductDto)
		{
			var value = _mapper.Map<Product>(updateProductDto);
			await _productCollection.FindOneAndReplaceAsync(x => x.ProductId == updateProductDto.ProductId, value);
		}
	}
}
