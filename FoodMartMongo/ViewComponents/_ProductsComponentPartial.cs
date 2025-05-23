using FoodMartMongo.Services.CategoryServices;
using FoodMartMongo.Services.ProductServices;
using Microsoft.AspNetCore.Mvc;

namespace FoodMartMongo.ViewComponents
{
	public class _ProductsComponentPartial : ViewComponent
	{
		private readonly IProductService _productService;

		public _ProductsComponentPartial(IProductService productService)
		{
			_productService = productService;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var values = await _productService.GetAllProductsAsync();
			return View(values);
		}
	}
}
