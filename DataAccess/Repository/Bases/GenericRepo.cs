using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract.Bases;
using DataAccess.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repository.Bases
{

    public class GenericRepo<T> : IGenericDal<T> where T : class
    {
        private readonly CoreContext _coreContext;

        public GenericRepo(CoreContext coreContext)
        {
            _coreContext = coreContext;
        }

        //protected GenericRepo()
        //{

        //}

        public void Delete(T t)
        {

            _coreContext.Remove(t);
            _coreContext.SaveChanges();

        }

        public T GetById(int id)
        {

            return _coreContext.Set<T>().Find(id);

        }

        public List<T> GetList()
        {

            return _coreContext.Set<T>().ToList();

        }

        public void Insert(T t)
        {

            _coreContext.Add(t);
            _coreContext.SaveChanges();

        }

        public void Update(T t)
        {

            _coreContext.Update(t);
            _coreContext.SaveChanges();

        }
    }
}
