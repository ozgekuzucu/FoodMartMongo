using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace FoodMartMongo.Entities
{
	public class PeopleViewing
	{
		[BsonId]
		[BsonRepresentation(BsonType.ObjectId)]
		public string PeopleViewingId { get; set; }
		public string Title { get; set; }
	}
}
