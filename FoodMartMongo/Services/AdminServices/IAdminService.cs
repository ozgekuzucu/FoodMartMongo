using FoodMartMongo.Entities;

namespace FoodMartMongo.Services.AdminServices
{
	public interface IAdminService
	{
		Task RegisterUserAsync(ApplicationUser user);
		Task<ApplicationUser> GetUserByUsernameAsync(string username);
		Task<bool> CheckPasswordAsync(ApplicationUser user, string password);
	}

}
