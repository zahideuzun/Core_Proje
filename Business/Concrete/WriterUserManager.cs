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
    public class WriterUserManager : IWriterUserService
    {
        private IWriterUserDal _writerUserDal;
        public WriterUserManager(IWriterUserDal writerUserDal)
        {
            _writerUserDal = writerUserDal;
        }

        public void TAdd(WriterUser t)
        {
            _writerUserDal.Insert(t);
        }

        public void TDelete(WriterUser t)
        {
            _writerUserDal.Delete(t);
        }

        public void TUpdate(WriterUser t)
        {
            _writerUserDal.Update(t);
        }

        public List<WriterUser> GetList()
        {
            return _writerUserDal.GetList();
        }

        public WriterUser GetById(int id)
        {
            return _writerUserDal.GetById(id);
        }

        public List<WriterUser> TGetListByFilter()
        {
            throw new NotImplementedException();
        }
    }
}
