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
	public class UserMessageManager : IUserMessageService
	{
		IUserMessageDal _userMessageDal;

		public UserMessageManager(IUserMessageDal userMessageDal)
		{
			_userMessageDal = userMessageDal;
		}
		public void TAdd(UserMessage t)
		{
			_userMessageDal.Insert(t);
		}

		public void TDelete(UserMessage t)
		{
			throw new NotImplementedException();
		}

		public void TUpdate(UserMessage t)
		{
			throw new NotImplementedException();
		}

		public List<UserMessage> GetList()
		{
			return _userMessageDal.GetList();
		}

		public UserMessage GetById(int id)
		{
			throw new NotImplementedException();
		}

		public List<UserMessage> TGetListByFilter()
		{
			throw new NotImplementedException();
		}

		public List<UserMessage> GetUserMessagesWithUserServices()
		{
			return _userMessageDal.GetUserMessagesWithUser();
		}
	}
}
