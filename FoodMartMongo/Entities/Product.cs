﻿using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace FoodMartMongo.Entities
{
	public class Product
	{
		[BsonId]
		[BsonRepresentation(BsonType.ObjectId)]
		public string ProductId { get; set; }
		public string Name { get; set; }
		public decimal Price { get; set; }
		public string ImageUrl { get; set; }
		public bool Status { get; set; }
		public int StockCount { get; set; }

		[BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
		public string CategoryId { get; set; }

		[BsonIgnore]
		public Category Category { get; set; }
	}
}
