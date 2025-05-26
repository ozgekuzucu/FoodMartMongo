using FoodMartMongo.Entities;
using FoodMartMongo.Services.AdminServices;
using FoodMartMongo.Settings;
using MongoDB.Driver;

public class AdminService : IAdminService
{
	private readonly IMongoCollection<ApplicationUser> _userCollection;

	public AdminService(IDatabaseSettings settings)
	{
		var client = new MongoClient(settings.ConnectionString);
		var database = client.GetDatabase(settings.DatabaseName);
		_userCollection = database.GetCollection<ApplicationUser>(settings.AdminCollectionName);
	}

	public async Task RegisterUserAsync(ApplicationUser user)
	{
		await _userCollection.InsertOneAsync(user);
	}

	public async Task<ApplicationUser> GetUserByUsernameAsync(string username)
	{
		return await _userCollection.Find(x => x.Username == username).FirstOrDefaultAsync();
	}

	public async Task<bool> CheckPasswordAsync(ApplicationUser user, string password)
	{
		return user.Password == password;
	}
	
}
