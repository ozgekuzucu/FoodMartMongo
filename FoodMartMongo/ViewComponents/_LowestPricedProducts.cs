using FoodMartMongo.Dtos.ProductDtos;
using FoodMartMongo.Services.CategoryServices;
using FoodMartMongo.Services.ProductServices;
using Microsoft.AspNetCore.Mvc;

namespace FoodMartMongo.ViewComponents
{
	public class _LowestPricedProducts : ViewComponent
	{
		private readonly IProductService _productService;

		public _LowestPricedProducts(IProductService productService)
		{
			_productService = productService;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var values = await _productService.GetAllProductsAsync();
			if (values == null)
			{
				values = new List<ResultProductDto>();
			}

			var lowestPricedProducts = values
				.OrderBy(p => p.Price) // fiyata göre artan sırala
				.Take(6)                // ilk 6 ürünü al
				.ToList();

			return View(lowestPricedProducts);
		}
	}
}
