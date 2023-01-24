using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
	public class ContactController : Controller
	{
		private MessageManager messageManager = new MessageManager(new EfMessageDal());

		public IActionResult Index()
		{
			var values = messageManager.GetList();
			return View(values);
		}

		public IActionResult DeleteContact(int id)
		{
			var values = messageManager.GetById(id);
			messageManager.TDelete(values);
			return RedirectToAction("Index");
		}

		public IActionResult ContactDetails(int id)
		{
			var values = messageManager.GetById(id);
			return View(values);
		}
	}
}
