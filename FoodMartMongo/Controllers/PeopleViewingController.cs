using FoodMartMongo.Dtos.PeopleViewingDtos;
using FoodMartMongo.Services.PeopleViewingServices;
using Microsoft.AspNetCore.Mvc;

namespace FoodMartMongo.Controllers
{
	public class PeopleViewingController : Controller
	{
		private readonly IPeopleViewingService _PeopleViewingService;

		public PeopleViewingController(IPeopleViewingService PeopleViewingService)
		{
			_PeopleViewingService = PeopleViewingService;
		}

		public async Task<IActionResult> PeopleViewingList()
		{
			var values = await _PeopleViewingService.GetAllPeopleViewingAsync();
			return View(values);
		}

		[HttpGet]
		public IActionResult CreatePeopleViewing()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> CreatePeopleViewing(CreatePeopleViewingDto createPeopleViewingDto)
		{
			await _PeopleViewingService.CreatePeopleViewingAsync(createPeopleViewingDto);
			return RedirectToAction("PeopleViewingList");
		}

		public async Task<IActionResult> DeletePeopleViewing(string id)
		{
			await _PeopleViewingService.DeletePeopleViewingAsync(id);
			return RedirectToAction("PeopleViewingList");
		}

		[HttpGet]
		public async Task<IActionResult> UpdatePeopleViewing(string id)
		{
			var value = await _PeopleViewingService.GetPeopleViewingByIdAsync(id);
			return View(value);
		}

		[HttpPost]
		public async Task<IActionResult> UpdatePeopleViewing(UpdatePeopleViewingDto updatePeopleViewingDto)
		{
			await _PeopleViewingService.UpdatePeopleViewingAsync(updatePeopleViewingDto);
			return RedirectToAction("PeopleViewingList");
		}
	}
}
