using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace FoodMartMongo.Entities
{
	public class Discount
	{
		[BsonId]
		[BsonRepresentation(BsonType.ObjectId)]
		public string DiscountId { get; set; }
		public string Title { get; set; }
		public string SubTitle { get; set; }
		public string ImageUrl { get; set; }
		public string DiscountRate { get; set; }
	}
}
