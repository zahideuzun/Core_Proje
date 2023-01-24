﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
	public class MessageManager : IMessageService
	{
		private IMessageDal _messageDal;
		public MessageManager(IMessageDal messageDal)
		{
			_messageDal = messageDal;
		}
		public void TAdd(Message t)
		{
			_messageDal.Insert(t);
		}

		public void TDelete(Message t)
		{
			throw new NotImplementedException();
		}

		public void TUpdate(Message t)
		{
			throw new NotImplementedException();
		}

		public List<Message> GetList()
        {
            return _messageDal.GetList() ?? new List<Message>();
        }

		public Message GetById(int id)
		{
			throw new NotImplementedException();
		}
	}
}
