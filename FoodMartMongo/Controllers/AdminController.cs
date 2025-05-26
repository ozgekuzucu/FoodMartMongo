using FoodMartMongo.Entities;
using FoodMartMongo.Services.AdminServices;
using Microsoft.AspNetCore.Mvc;

namespace FoodMartMongo.Controllers
{
	public class AdminController : Controller
	{
		private readonly IAdminService _adminService;

		public AdminController(IAdminService adminService)
		{
			_adminService = adminService;
		}

		[HttpGet]
		public IActionResult Register()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Register(ApplicationUser user)
		{
			if (string.IsNullOrEmpty(user.Username) || string.IsNullOrEmpty(user.Password))
			{
				ModelState.AddModelError("", "Kullanıcı adı ve şifre gerekli.");
				return View(user);
			}

			await _adminService.RegisterUserAsync(user);
			TempData["SuccessMessage"] = "Kayıt başarılı, giriş yapabilirsiniz.";
			return RedirectToAction("Login");
		}

		[HttpGet]
		public IActionResult Login()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Login(string username, string password)
		{
			var user = await _adminService.GetUserByUsernameAsync(username);
			if (user == null || !await _adminService.CheckPasswordAsync(user, password))
			{
				ModelState.AddModelError("", "Geçersiz kullanıcı adı veya şifre.");
				return View();
			}

			HttpContext.Session.SetString("UserId", user.ApplicationUserId);
			return RedirectToAction("CategoryList", "Category");
		}
		[HttpGet]
		public IActionResult Logout()
		{
			HttpContext.Session.Clear(); 
			return RedirectToAction("Login","Admin"); 
		}

	}

}
