using Business.Concrete;
using Business.ValidationRules;
using DataAccess.EntityFramework;
using Entities.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
	public class PortfolioController : Controller
	{
		private PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioDal());

		public IActionResult Index()
		{
			ViewBag.v1 = "Proje Listesi";
			ViewBag.v2 = "Projeler";
			ViewBag.v3 = "Proje Listesi";
			var values = portfolioManager.GetList();
			return View(values);
		}

		[HttpGet]
		public IActionResult AddPortfolio()
		{
			ViewBag.v1 = "Proje Listesi";
			ViewBag.v2 = "Projeler";
			ViewBag.v3 = "Proje Ekleme";
			return View();
		}

		[HttpPost]
		public IActionResult AddPortfolio(Portfolio portfolio)
		{
			PortfolioValidator validator = new PortfolioValidator();
			ValidationResult results = validator.Validate(portfolio);
			if (results.IsValid)
			{
				portfolioManager.TAdd(portfolio);
				return RedirectToAction("Index");
			}
			else
			{
				foreach (var item in results.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
			}

			return View();
		}

		public IActionResult DeletePortfolio(int id)
		{
			var values = portfolioManager.GetById(id);
			portfolioManager.TDelete(values);
			return RedirectToAction("Index");
		}

		[HttpGet]
		public IActionResult EditPortfolio(int id)
		{
			ViewBag.v1 = "Proje Güncelleme";
			ViewBag.v2 = "Projeler";
			ViewBag.v3 = "Proje Güncelleme";
			var values = portfolioManager.GetById(id);
			return View(values);
		}

		[HttpPost]
		public IActionResult EditPortfolio(Portfolio portfolio)
		{
			PortfolioValidator validator = new PortfolioValidator();
			ValidationResult results = validator.Validate(portfolio);
			if (results.IsValid)
			{
				portfolioManager.TUpdate(portfolio);
				return RedirectToAction("Index");
			}
			else
			{
				foreach (var item in results.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
			}
			return View();
		}
	}
}

