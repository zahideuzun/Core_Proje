using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.SocialMedia
{
	public class SocialMediaList : ViewComponent
	{
		private SocialMediaManager socialMediaManager = new SocialMediaManager(new EfSocialMediaDal());
		public IViewComponentResult Invoke()
		{
			var values = socialMediaManager.GetList();
			return View(values);
		}
	}
}
