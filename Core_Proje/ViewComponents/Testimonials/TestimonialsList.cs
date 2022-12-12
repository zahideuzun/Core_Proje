using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.TestimonialsList
{
	public class TestimonialList : ViewComponent
	{
		ITestimonialService _testimonialService;

		public TestimonialList(ITestimonialService testimonialService)
		{
			_testimonialService = testimonialService;
		}
		public IViewComponentResult Invoke()
		{
			var values = _testimonialService.GetList();
			return View(values);
		}
	}
	{
	}
}
