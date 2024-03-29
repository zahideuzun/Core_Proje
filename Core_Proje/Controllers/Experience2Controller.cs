﻿using Business.Concrete;
using DataAccess.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Core_Proje.Controllers
{
	public class Experience2Controller : Controller
	{
		private ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal());
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult ListExperience()
		{
			var values = JsonConvert.SerializeObject(experienceManager.GetList());
			return Json(values);
		}

		[HttpPost]
		public IActionResult AddExperience(Experience p)
		{
			experienceManager.TAdd(p);
			var values = JsonConvert.SerializeObject(p);
			return Json(values);
		}

		public IActionResult GetById(int ExperienceId)
		{
			var v = experienceManager.GetById(ExperienceId);
			var values = JsonConvert.SerializeObject(v);
			return Json(values);
		}

		public IActionResult DeleteExperience(int id)
		{
			var v = experienceManager.GetById(id);
			experienceManager.TDelete(v);
			return NoContent();
		}
	}
}
