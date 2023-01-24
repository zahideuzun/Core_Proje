using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
	public class TestimonialManager : ITestimonialService
	{
		private ITestimonialDal _testimonialDal;
		public TestimonialManager(ITestimonialDal testimonialDal)
		{
			_testimonialDal = testimonialDal;
		}
		public void TAdd(Testimonial t)
		{
			_testimonialDal.Insert(t);
		}

		public void TDelete(Testimonial t)
		{
			_testimonialDal.Delete(t);
		}

		public void TUpdate(Testimonial t)
		{
			_testimonialDal.Update(t);
		}

		public List<Testimonial> GetList()
		{
			return _testimonialDal.GetList();
		}

		public Testimonial GetById(int id)
		{
			return _testimonialDal.GetById(id);
		}

		public List<Testimonial> TGetListByFilter()
		{
			throw new NotImplementedException();
		}
	}
}
