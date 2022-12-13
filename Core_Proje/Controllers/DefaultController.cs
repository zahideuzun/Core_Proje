using Business.Abstract;
using Business.Concrete;
using Core_Proje.ViewComponents.Contact;
using DataAccess.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
	
	public class DefaultController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

        public PartialViewResult HeaderPartial()
        {
			return PartialView();

        }

        public PartialViewResult NavbarPartial()
        {
            return NavbarPartial();
        }
        [HttpGet]
        public PartialViewResult SendMessage()
        {
	        return PartialView();
        }
		[HttpPost]
        public PartialViewResult SendMessage(Message p)
        {
	        MessageManager messageManager = new MessageManager(new EfMessageDal());
	        p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
	        p.Status = true;
	        messageManager.TAdd(p);
			return PartialView();
        }
	}

}
