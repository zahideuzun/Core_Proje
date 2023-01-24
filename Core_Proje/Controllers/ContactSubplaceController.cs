using Business.Concrete;
using DataAccess.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
	public class ContactSubplaceController : Controller
	{
		ContactManager contactManager = new ContactManager(new EfContactDal());
		[HttpGet]
		public IActionResult Index()
		{
			var values = contactManager.GetById(1);
			return View(values);
		}
		[HttpPost]
		public IActionResult Index(Contact contact)
		{
			contactManager.TUpdate(contact);
			return RedirectToAction("Index", "Default");
		}
	}
}
