using Business.Concrete;
using Core_Proje.ViewComponents.TestimonialsList;
using DataAccess.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
	public class TestimonialController : Controller
    {
        private TestimonialManager testimonialManager = new TestimonialManager(new EfTestimonialDal());
		public IActionResult Index()
        {
            var values = testimonialManager.GetList();
			return View(values);
		}

        public IActionResult DeleteTestimonial(int id)
        {
            var values = testimonialManager.GetById(id);
            testimonialManager.TDelete(values);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult EditTestimonial(int id)
        {
            var values = testimonialManager.GetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditTestimonial(Testimonial testimonial)
        {
            testimonialManager.TUpdate(testimonial);
            return RedirectToAction("Index");
        }
    }
}
