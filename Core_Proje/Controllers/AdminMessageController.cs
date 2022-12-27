using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
	public class AdminMessageController : Controller
	{
		WriterMessageManager writerMessageManager = new WriterMessageManager(new EfWriterMessageDal());
		public IActionResult ReceiverMessageList()
		{
			string p;
			p = "admin@gmail.com";
			var values = writerMessageManager.GetListReceiverMessage(p);
			return View(values);
		}
		public IActionResult SenderMessageList()
		{
			string p;
			p = "admin@gmail.com";
			var values = writerMessageManager.GetListSenderMessage(p);
			return View(values);
		}

		public IActionResult AdminMessageDetails(int id)
		{
			var values = writerMessageManager.GetById(id);
			return View(values);
		}

		public IActionResult DeleteAdminMessage(int id)
		{
			string p;
			p = "admin@gmail.com";
			var values = writerMessageManager.GetById(id);
			if (values.Receiver == p)
			{
				writerMessageManager.TDelete(values);
				return RedirectToAction("ReceiverMessageList");
			}
			else
			{
				writerMessageManager.TDelete(values);
				return RedirectToAction("SenderMessageList");
			}
		}
		[HttpGet]
		public IActionResult AdminMessageSend()
		{
			return View();
		}

		[HttpPost]
		public IActionResult AdminMessageSend(WriterMessage p)
		{
			p.Sender = "admin@gmail.com";
			p.SenderName = "Admin";
			p.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
			CoreContext coreContext = new CoreContext();
			var usernamesurname = coreContext.Users.Where(x => x.Email == p.Receiver).Select(y => y.Name + " " +y.Surname)
				.FirstOrDefault(); // kullanıcının maili yerine tam isim ve soyismi yazsın istiyorum.
			p.ReceiverName = usernamesurname;
			writerMessageManager.TAdd(p);
			return RedirectToAction("SenderMessageList");
		}
	}
}
