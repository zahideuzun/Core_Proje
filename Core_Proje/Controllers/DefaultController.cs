using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
	public class DefaultController : Controller
	{
		//denemes
		public IActionResult Index()
		{
			return View();
		}
	}
}
