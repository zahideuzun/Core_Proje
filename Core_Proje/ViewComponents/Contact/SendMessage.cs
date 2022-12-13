using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Contact
{
	public class SendMessage : ViewComponent
	{
		IMessageService _messageService;

		public SendMessage(IMessageService messageService)
		{
			_messageService = messageService;
		}
		[HttpGet]
		public IViewComponentResult Invoke()
		{
			return View();
		}

		//[HttpPost]
		//public IViewComponentResult Invoke(Message p)
		//{
		//	p.Date= Convert.ToDateTime(DateTime.Now.ToShortDateString());
		//	p.Status = true;
		//	_messageService.TAdd(p);
		//	return View();
		//}

	}

}
