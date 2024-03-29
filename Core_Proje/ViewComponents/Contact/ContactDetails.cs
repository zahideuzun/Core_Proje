﻿using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Contact
{
	public class ContactDetails : ViewComponent
	{
		IContactService _contactService;

		public ContactDetails(IContactService contactService)
		{
			_contactService = contactService;
		}
		public IViewComponentResult Invoke()
		{
			var values = _contactService.GetList();
			return View(values);
		}
	}
}
