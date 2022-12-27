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
	public class SocialMediaManager : ISocialMediaService
	{
		private ISocialMediaDal _socialMediaDal;
		public SocialMediaManager(ISocialMediaDal socialMediaDal)
		{
			_socialMediaDal = socialMediaDal;
		}

		public void TAdd(SocialMedia t)
		{
			_socialMediaDal.Insert(t);
		}

		public void TDelete(SocialMedia t)
		{
			_socialMediaDal.Delete(t);
		}

		public void TUpdate(SocialMedia t)
		{
			_socialMediaDal.Update(t);
		}

		public List<SocialMedia> GetList()
		{
			return _socialMediaDal.GetList();
		}

		public SocialMedia GetById(int id)
		{
			return _socialMediaDal.GetById(id);
		}

		public List<SocialMedia> TGetListByFilter()
		{
			throw new NotImplementedException();
		}
	}
}
