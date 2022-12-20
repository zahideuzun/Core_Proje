﻿using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Dashboard
{
	public class MessageList : ViewComponent
	{
		private UserMessageManager messageManager = new UserMessageManager(new EfUserMessageDal());
		public IViewComponentResult Invoke()
		{
			var values = messageManager.GetUserMessagesWithUserServices();
			return View(values);
		}
	}

}
