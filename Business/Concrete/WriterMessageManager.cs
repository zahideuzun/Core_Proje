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
			_writerMessageDal.Insert(t);
		}

		public void TDelete(WriterMessage t)
		{
			_writerMessageDal.Delete(t);
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
			return _writerMessageDal.GetById(id);
		}

		public List<WriterMessage> TGetListByFilter()
		{
			throw new NotImplementedException();
		}


		public List<WriterMessage> GetListSenderMessage(string p)
		{
			return _writerMessageDal.GetByFilter(x => x.Sender == p);
		}

		public List<WriterMessage> GetListReceiverMessage(string p)
		{
			return _writerMessageDal.GetByFilter(x => x.Receiver == p);
		}
	}
}
