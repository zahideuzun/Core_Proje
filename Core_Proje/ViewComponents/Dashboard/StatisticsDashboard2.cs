using DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Dashboard
{
	public class StatisticsDashboard2 : ViewComponent
	{
		CoreContext c = new CoreContext();
		public IViewComponentResult Invoke()
		{
			ViewBag.v1 = c.Portfolios.Count();
			ViewBag.v2 = c.Messages.Count();
			ViewBag.v3 = c.Services.Count();
			return View();
		}
	}

}
