using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace FoodMartMongo.Entities
{
	public class Customer
	{
		[BsonId]
		[BsonRepresentation(BsonType.ObjectId)]//bsontype ile ilgili property nin türünü belirleriz
		public string CustomerId { get; set; }
		public string CustomerName { get; set; }
		public string CustomerSurname { get; set; }
	}
}
