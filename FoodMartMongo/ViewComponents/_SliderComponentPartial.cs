using FoodMartMongo.Services.CategoryServices;
using FoodMartMongo.Services.FeatureServices;
using Microsoft.AspNetCore.Mvc;

namespace FoodMartMongo.ViewComponents
{
	public class _SliderComponentPartial : ViewComponent
	{
		private readonly IFeatureService _featureService;

		public _SliderComponentPartial(IFeatureService featureService)
		{
			_featureService = featureService;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var values = await _featureService.GetAllFeatureAsync();
			return View(values);
		}
	}
}
