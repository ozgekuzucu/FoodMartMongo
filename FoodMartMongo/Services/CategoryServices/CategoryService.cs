using AutoMapper;
using FoodMartMongo.Dtos.CategoryDtos;
using FoodMartMongo.Entities;
using FoodMartMongo.Settings;
using MongoDB.Driver;

namespace FoodMartMongo.Services.CategoryServices
{
	public class CategoryService : ICategoryService
	{
		private readonly IMongoCollection<Category> _categoryCollection;
		private readonly IMapper _mapper;

		public CategoryService(IMapper mapper, IDatabaseSettings _databaseSettings)
		{
			var client = new MongoClient(_databaseSettings.ConnectionString);
			var database = client.GetDatabase(_databaseSettings.DatabaseName);
			_categoryCollection = database.GetCollection<Category>(_databaseSettings.CategoryCollectionName);
			_mapper = mapper;
		}

		public async Task CreateCategoryAsync(CreateCategoryDto createCategoryDto)
		{
			var value = _mapper.Map<Category>(createCategoryDto);
			await _categoryCollection.InsertOneAsync(value);
		}

		public async Task DeleteCategoryAsync(string id)
		{
			await _categoryCollection.DeleteOneAsync(id);
		}

		public Task<List<ResultCategoryDto>> GetAllCategoryAsync()
		{
			throw new NotImplementedException();
		}

		public Task<GetCategoryByIdDto> GetCategoryByIdAsync(string id)
		{
			throw new NotImplementedException();
		}

		public async Task UpdateCategoryAsync(UpdateCategoryDto updateCategoryDto)
		{
			var values = _mapper.Map<Category>(updateCategoryDto);
			await _categoryCollection.FindOneAndReplaceAsync(x=>x.CategoryId ==updateCategoryDto.CategoryId, values);
		}
	}
}
