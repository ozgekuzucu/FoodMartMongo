using FoodMartMongo.Dtos.PeopleViewingDtos;

namespace FoodMartMongo.Services.PeopleViewingServices
{
	public interface IPeopleViewingService
	{
		Task<List<ResultPeopleViewingDto>> GetAllPeopleViewingAsync();
		Task CreatePeopleViewingAsync(CreatePeopleViewingDto createPeopleViewingDto);
		Task UpdatePeopleViewingAsync(UpdatePeopleViewingDto updatePeopleViewingDto);
		Task DeletePeopleViewingAsync(string id);
		Task<GetPeopleViewingByIdDto> GetPeopleViewingByIdAsync(string id);
	}
}
