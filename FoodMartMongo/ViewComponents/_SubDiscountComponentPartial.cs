using FoodMartMongo.Services.CategoryServices;
using FoodMartMongo.Services.DiscountServices;
using Microsoft.AspNetCore.Mvc;

namespace FoodMartMongo.ViewComponents
{
	public class _SubDiscountComponentPartial : ViewComponent
	{
		private readonly IDiscountService _discountService;

		public _SubDiscountComponentPartial(IDiscountService discountService)
		{
			_discountService = discountService;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var values = await _discountService.GetAllDiscountAsync();
			return View(values);
		}
	}
}
