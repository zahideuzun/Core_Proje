using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Areas.Writer.Controllers
{
    [Area("Writer")]
    //[Route("Write/Message")]
    public class MessageController : Controller
    {
	    private WriterMessageManager writerMessageManager = new WriterMessageManager(new EfWriterMessageDal());

        private readonly UserManager<WriterUser> _userManager;

        public MessageController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }
        //[Route("")]
        //[Route("ReceiverMessage")]
        public async Task<IActionResult> ReceiverMessage(string p)
        {
	        var values = await _userManager.FindByNameAsync(User.Identity.Name);
	        p = values.Email;
	        var messageList = writerMessageManager.GetListReceiverMessage(p);
            return View(messageList);
        }
        //[Route("")]
        //[Route("SenderMessage")]
        public async Task<IActionResult> SenderMessage(string p)
        {
	        var values = await _userManager.FindByNameAsync(User.Identity.Name);
	        p = values.Email;
	        var messageList = writerMessageManager.GetListSenderMessage(p);
	        return View(messageList);
        }
		
		//[Route("MessageDetails/{id}")]
		public IActionResult MessageDetails(int id)
        {
	        WriterMessage writerMessage = writerMessageManager.GetById(id);
	        return View(writerMessage);
        }
		//[Route("ReceiverMessageDetails/{id}")]
		public IActionResult ReceiverMessageDetails(int id)
        {
	        WriterMessage writerMessage = writerMessageManager.GetById(id);
	        return View(writerMessage);
        }

        [HttpGet]
        //[Route("")]
        //[Route("SendMessage")]
        public IActionResult SendMessage()
        {
	        return View();
        }

        [HttpPost]
        //[Route("")]
        //[Route("SenderMessage")]
        public async Task<IActionResult> SendMessage(WriterMessage p)
        {
			var values = await _userManager.FindByNameAsync(User.Identity.Name);
			string mail = values.Email;
            string name = values.Name + values.Surname;
			p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
			p.Sender = mail;
			p.SenderName = name;
			CoreContext coreContext = new CoreContext();
			var usernamesurname = coreContext.Users.Where(x => x.Email == p.Receiver).Select(y => y.Name + y.Surname)
				.FirstOrDefault(); // kullanıcının maili yerine tam isim ve soyismi yazsın istiyorum.
			p.ReceiverName = usernamesurname;
            writerMessageManager.TAdd(p);
            return RedirectToAction("SenderMessage");
		}
    }
}
