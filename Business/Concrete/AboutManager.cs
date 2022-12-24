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
	public class AboutManager : IAboutService
	{
		private IAboutDal _aboutDal;

		public AboutManager(IAboutDal aboutDal)
		{
			_aboutDal = aboutDal;
		}

		public About GetById(int id)
		{
			return _aboutDal.GetById(id);
		}

		public List<About> TGetListByFilter()
		{
			throw new NotImplementedException();
		}

		public void TAdd(About t)
		{
			_aboutDal.Insert(t);
		}

		public void TDelete(About t)
		{
			_aboutDal.Delete(t);
		}

		public void TUpdate(About t)
		{
			_aboutDal.Update(t);
		}

		public List<About> GetList()
		{
			return _aboutDal.GetList();
		}

	}
}
