using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace FoodMartMongo.Entities
{
	public class Feature
	{
		[BsonId]
		[BsonRepresentation(BsonType.ObjectId)]
		public string FeaturetId { get; set; }
		public string Title { get; set; }
		public string SubTitle { get; set; }
		public string ImageUrl { get; set; }
		public string Description { get; set; }
	}
}
