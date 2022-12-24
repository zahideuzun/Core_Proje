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
	public class ExperienceManager : IExperienceService
	{
		private IExperienceDal _experienceDal;

		public ExperienceManager(IExperienceDal experienceDal)
		{
			_experienceDal = experienceDal;
		}

		public void TAdd(Experience t)
		{
			_experienceDal.Insert(t);
		}

		public void TDelete(Experience t)
		{
			_experienceDal.Delete(t);
		}

		public void TUpdate(Experience t)
		{
			_experienceDal.Update(t);
		}

		public List<Experience> GetList()
		{
			return _experienceDal.GetList();
		}

		public Experience GetById(int id)
		{
			return _experienceDal.GetById(id);
		}

		public List<Experience> TGetListByFilter()
		{
			throw new NotImplementedException();
		}
	}
}
