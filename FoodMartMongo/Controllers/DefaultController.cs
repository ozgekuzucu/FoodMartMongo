using Microsoft.AspNetCore.Mvc;

namespace FoodMartMongo.Controllers
{
	public class DefaultController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
