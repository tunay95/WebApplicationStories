using Microsoft.AspNetCore.Mvc;

namespace WebApplicationStories.Controllers
{
	public class HomeController:Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
