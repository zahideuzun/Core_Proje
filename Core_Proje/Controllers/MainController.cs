using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
	public class MainController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
