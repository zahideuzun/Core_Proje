using Business.Concrete;
using DataAccess.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
	public class SocialMediaController : Controller
	{
		private SocialMediaManager socialMediaManager = new SocialMediaManager(new EfSocialMediaDal());
		public IActionResult Index()
		{
			var values = socialMediaManager.GetList();
			return View(values);
		}
		[HttpGet]
		public IActionResult AddSocialMedia()
		{
			return View();
		}
		[HttpPost]
		public IActionResult AddSocialMedia(SocialMedia p)
		{
			p.Status = true;
			socialMediaManager.TAdd(p);
			return RedirectToAction("Index");
		}
		public IActionResult DeleteSocialMedia(int id)
		{
			var values = socialMediaManager.GetById(id);
			socialMediaManager.TDelete(values);
			return RedirectToAction("Index");
		}
		[HttpGet]
		public IActionResult EditSocialMedia(int id)
		{
			var values = socialMediaManager.GetById(id);
			return View(values);
		}
		[HttpPost]
		public IActionResult EditSocialMedia(SocialMedia p)
		{
			socialMediaManager.TUpdate(p);
			return RedirectToAction("Index");
		}
	}
}
