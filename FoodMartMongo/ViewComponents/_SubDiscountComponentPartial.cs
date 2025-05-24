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
			var allDiscounts = await _discountService.GetAllDiscountAsync();

			// İlk 2 veriyi al
			var subDiscounts = allDiscounts
				.OrderBy(x => x.DiscountId) 
				.Take(2)
				.ToList();

			return View(subDiscounts);
		}
	}
}
