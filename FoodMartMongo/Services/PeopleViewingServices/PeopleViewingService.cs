using AutoMapper;
using FoodMartMongo.Dtos.CategoryDtos;
using FoodMartMongo.Dtos.PeopleViewingDtos;
using FoodMartMongo.Entities;
using FoodMartMongo.Settings;
using MongoDB.Driver;

namespace FoodMartMongo.Services.PeopleViewingServices
{
	public class PeopleViewingService : IPeopleViewingService
	{
		private readonly IMongoCollection<PeopleViewing> _peopleViewingCollection;
		private readonly IMapper _mapper;

		public PeopleViewingService(IMapper mapper, IDatabaseSettings _databaseSettings)
		{
			var client = new MongoClient(_databaseSettings.ConnectionString);
			var database = client.GetDatabase(_databaseSettings.DatabaseName);
			_peopleViewingCollection = database.GetCollection<PeopleViewing>(_databaseSettings.PeopleViewingCollectionName);
			_mapper = mapper;
		}

		public async Task CreatePeopleViewingAsync(CreatePeopleViewingDto createPeopleViewingDto)
		{
			var value = _mapper.Map<PeopleViewing>(createPeopleViewingDto);
			await _peopleViewingCollection.InsertOneAsync(value);
		}

		public async Task DeletePeopleViewingAsync(string id)
		{
			await _peopleViewingCollection.DeleteOneAsync(x => x.PeopleViewingId == id);
		}

		public async Task<List<ResultPeopleViewingDto>> GetAllPeopleViewingAsync()
		{
			var values = await _peopleViewingCollection.Find(x => true).ToListAsync();
			return _mapper.Map<List<ResultPeopleViewingDto>>(values);
		}
	
		public async Task<GetPeopleViewingByIdDto> GetPeopleViewingByIdAsync(string id)
		{
			var value = await _peopleViewingCollection.Find(x=>x.PeopleViewingId==id).FirstOrDefaultAsync();
			return _mapper.Map<GetPeopleViewingByIdDto>(value);
		}

		public async Task UpdatePeopleViewingAsync(UpdatePeopleViewingDto updatePeopleViewingDto)
		{
			var values = _mapper.Map<PeopleViewing>(updatePeopleViewingDto);
			await _peopleViewingCollection.FindOneAndReplaceAsync(x=>x.PeopleViewingId==updatePeopleViewingDto.PeopleViewingId, values);
		}
	}
}
