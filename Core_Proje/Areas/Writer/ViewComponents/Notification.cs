using Business.Abstract;
using Business.Concrete;
using DataAccess.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Areas.Writer.ViewComponents
{
    public class Notification : ViewComponent
    {
	    AnnouncementManager announcementManager = new AnnouncementManager(new EfAnnouncementDal());

		public IViewComponentResult Invoke()
        {
            var values = announcementManager.GetList().Take(2).ToList();
            return View(values);
        }
    }
}
