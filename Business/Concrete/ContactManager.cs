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
	public class ContactManager : IContactService
	{
		private IContactDal _contactDal;
		public ContactManager(IContactDal contactDal)
		{
			_contactDal = contactDal;
		}

		public void TAdd(Contact t)
		{
			_contactDal.Insert(t);
		}

		public void TDelete(Contact t)
		{
			_contactDal.Delete(t);
		}

		public void TUpdate(Contact t)
		{
			_contactDal.Update(t);
		}

		public List<Contact> GetList()
		{
			return _contactDal.GetList();
		}

		public Contact GetById(int id)
		{
			return _contactDal.GetById(id);
		}
	}
}
