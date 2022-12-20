using Business.Concrete;
using DataAccess.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
	public class AboutController : Controller
	{

		AboutManager aboutManager = new AboutManager(new EfAboutDal());
		[HttpGet]
		public IActionResult Index()
		{
			ViewBag.v1 = "Hakkımda Sayfası";
			ViewBag.v2 = "Hakkımda";
			ViewBag.v3 = "Hakkımda Sayfası";
			var values = aboutManager.GetById(2);
			return View(values);
		}
		[HttpPost]
		public IActionResult Index(About about)
		{
			aboutManager.TUpdate(about);
			return RedirectToAction("Index", "Default");
		}
	}
}
