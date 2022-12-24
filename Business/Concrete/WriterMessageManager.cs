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
	public class WriterMessageManager : IWriterMessageService
	{
		private IWriterMessageDal _writerMessageDal;

		public WriterMessageManager(IWriterMessageDal writerMessageDal)
		{
			_writerMessageDal = writerMessageDal;
		}
		public void TAdd(WriterMessage t)
		{
			throw new NotImplementedException();
		}

		public void TDelete(WriterMessage t)
		{
			throw new NotImplementedException();
		}

		public void TUpdate(WriterMessage t)
		{
			throw new NotImplementedException();
		}

		public List<WriterMessage> GetList()
		{
			throw new NotImplementedException();
		}

		public WriterMessage GetById(int id)
		{
			throw new NotImplementedException();
		}

		public List<WriterMessage> TGetListByFilter(string p)
		{
			return _writerMessageDal.GetByFilter(x => x.Receiver == p);
		}

	}
}
