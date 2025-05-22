using Microsoft.AspNetCore.Mvc;

namespace FoodMartMongo.ViewComponents
{
	public class _LowestPricedProducts : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
