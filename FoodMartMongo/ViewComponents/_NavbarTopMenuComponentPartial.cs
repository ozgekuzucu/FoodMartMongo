using Microsoft.AspNetCore.Mvc;

namespace FoodMartMongo.ViewComponents
{
	public class _NavbarTopMenuComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
