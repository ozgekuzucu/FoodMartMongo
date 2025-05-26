using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace FoodMartMongo.Entities
{
	public class ApplicationUser
	{
		[BsonId] 
		[BsonRepresentation(BsonType.ObjectId)]
		public string ApplicationUserId { get; set; } 
		public string Username { get; set; }
		public string Password { get; set; } 
		public string ImageUrl { get; set; } 
	}
}
