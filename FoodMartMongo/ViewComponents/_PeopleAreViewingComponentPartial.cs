using FoodMartMongo.Services.CategoryServices;
using FoodMartMongo.Services.PeopleViewingServices;
using Microsoft.AspNetCore.Mvc;

namespace FoodMartMongo.ViewComponents
{
	public class _PeopleAreViewingComponentPartial : ViewComponent
	{
		private readonly IPeopleViewingService _peopleViewingService;

		public _PeopleAreViewingComponentPartial(IPeopleViewingService peopleViewingService)
		{
			_peopleViewingService = peopleViewingService;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var values = await _peopleViewingService.GetAllPeopleViewingAsync();
			return View(values);
		}
	}
}
