using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Dashboard
{
	public class MessageList : ViewComponent
	{
		private MessageManager messageManager = new MessageManager(new EfMessageDal());
		public IViewComponentResult Invoke()
		{
			var values = messageManager.GetList();
			return View(values);
		}
	}

}
