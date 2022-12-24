using System.Xml.Linq;
using DataAccess.Concrete;
using Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Areas.Writer.Controllers
{
	[Area("Writer")]
	public class DashboardController : Controller
	{
        private readonly UserManager<WriterUser> _userManager;

        public DashboardController(UserManager<WriterUser> userManager)
        {
			_userManager = userManager;
        }

        
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.v = values.Name + " " + values.Surname;

            //weather api
            //string api = "36b6bca5860ea93b93a6beecdd85c070";
            string connection =
                "https://api.openweathermap.org/data/2.5/weather?q=ankara&appid=36b6bca5860ea93b93a6beecdd85c070&mode=xml&units=metric";
            XDocument document = XDocument.Load(connection);
            ViewBag.v5 = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;


            CoreContext c = new CoreContext();
            ViewBag.v1 = 0;
            ViewBag.v2 = c.Announcements.Count();
            ViewBag.v3 = 0;
            ViewBag.v4 = c.Skills.Count();
			return View();
		}
	}
}
