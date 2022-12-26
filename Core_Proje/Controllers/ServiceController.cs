using Business.Concrete;
using DataAccess.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
	public class ServiceController : Controller
	{
		ServiceManager serviceManager = new ServiceManager(new EfServiceDal());
		public IActionResult Index()
		{
			
			var values = serviceManager.GetList();
			return View(values);
		}
		[HttpGet]
		public IActionResult AddService()
		{
			
			return View();
		}

		[HttpPost]
		public IActionResult AddService(Service service)
		{
			serviceManager.TAdd(service);
			return RedirectToAction("Index");
		}

		public IActionResult DeleteService(int id)
		{
			var values = serviceManager.GetById(id);
			serviceManager.TDelete(values);
			return RedirectToAction("Index");
		}

		[HttpGet]
		public IActionResult EditService(int id)
		{
			var values = serviceManager.GetById(id);
			return View(values);
		}
		[HttpPost]
		public IActionResult EditService(Service service)
		{
			serviceManager.TUpdate(service);
			return RedirectToAction("Index");
		}

	}
}
