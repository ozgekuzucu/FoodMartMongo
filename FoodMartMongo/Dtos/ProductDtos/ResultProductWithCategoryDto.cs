using FoodMartMongo.Dtos.CategoryDtos;

namespace FoodMartMongo.Dtos.ProductDtos
{
	public class ResultProductWithCategoryDto
	{
		public string ProductId { get; set; }
		public string Name { get; set; }
		public decimal ProductPrice { get; set; }
		public decimal StockCount { get; set; }
		public string ProductImageUrl { get; set; }
		public string CategoryId { get; set; }
		public ResultCategoryDto Category { get; set; }
	}
}
