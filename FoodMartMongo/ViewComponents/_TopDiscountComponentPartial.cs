using FoodMartMongo.Services.DiscountServices;
using Microsoft.AspNetCore.Mvc;

namespace FoodMartMongo.ViewComponents
{
	public class _TopDiscountComponentPartial : ViewComponent
	{
		private readonly IDiscountService _discountService;

		public _TopDiscountComponentPartial(IDiscountService discountService)
		{
			_discountService = discountService;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var allDiscounts = await _discountService.GetAllDiscountAsync();
			var topDiscounts = allDiscounts.Skip(Math.Max(0, allDiscounts.Count - 2)).ToList();
			return View(topDiscounts);

		}

	}
}
