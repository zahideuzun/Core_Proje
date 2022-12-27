using Business.Concrete;
using DataAccess.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
	[Authorize(Roles = "Admin")]
	public class ExperienceController : Controller
	{
		private ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal());
		public IActionResult Index()
		{
			var values = experienceManager.GetList();
			return View(values);
		}
		[HttpGet]
		public IActionResult AddExperience()
		{
			return View();
		}

		[HttpPost]
		public IActionResult AddExperience(Experience experience)
		{
			experienceManager.TAdd(experience);
			return RedirectToAction("Index");
		}
		public IActionResult DeleteExperience(int id)
		{
			var values = experienceManager.GetById(id);
			experienceManager.TDelete(values);
			return RedirectToAction("Index");
		}

		[HttpGet]
		public IActionResult EditExperience(int id)
		{
			var values = experienceManager.GetById(id);
			return View(values);
		}
		[HttpPost]
		public IActionResult EditExperience(Experience experience)
		{
			experienceManager.TUpdate(experience);
			return RedirectToAction("Index");
		}
	}
}
