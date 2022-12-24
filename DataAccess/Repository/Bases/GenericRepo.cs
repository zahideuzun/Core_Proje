using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract.Bases;
using DataAccess.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repository.Bases
{

    public class GenericRepo<T,TContext> : IGenericDal<T> where T : class where TContext :DbContext,new()
    {
      
        public void Delete(T t)
        {
            using (var coreContext = new TContext())
            {
                coreContext.Remove(t);
                coreContext.SaveChanges();
            }
        }

        public T GetById(int id)
        {
            using (var coreContext = new TContext())
            {
                return coreContext.Set<T>().Find(id);
            }
        }

        public List<T> GetByFilter(Expression<Func<T, bool>> filter)
        {
	        using (var coreContext = new TContext())
	        {
		        return coreContext.Set<T>().Where(filter).ToList();

	        }
           
        }

        public List<T> GetList()
        {

            using (var coreContext = new TContext())
            {
                return coreContext.Set<T>().ToList();
            }
        }

        public void Insert(T t)
        {
            using (var coreContext = new TContext())
            {
                coreContext.Add(t);
                coreContext.SaveChanges();
            }

        }

        public void Update(T t)
        {
            using (var coreContext = new TContext())
            {
                coreContext.Update(t);
                coreContext.SaveChanges();
            }
        }
    }
}
