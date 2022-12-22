using Business.Concrete;
using DataAccess.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Authorize]
    public class DefaultController : Controller
    {
        AnnouncementManager announcementManager = new AnnouncementManager(new EfAnnouncementDal());
		public IActionResult Index()
        {
            var values = announcementManager.GetList();
			return View(values);
		}

		public IActionResult AnnouncementDetails(int id)
		{
			Announcement announcement = announcementManager.GetById(id);
			return View(announcement);
		}
	}
}
