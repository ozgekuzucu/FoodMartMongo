﻿using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace FoodMartMongo.Dtos.ProductDtos
{
	public class GetProductByIdDto
	{
		public string ProductId { get; set; }
		public string Name { get; set; }
		public decimal Price { get; set; }
		public string ImageUrl { get; set; }
		public bool Status { get; set; }
		public int StockCount { get; set; }
	}
}
