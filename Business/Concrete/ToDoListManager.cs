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
	public class ToDoListManager : IToDoListService
	{
		private IToDoListDal _toDoListDal;
		public ToDoListManager(IToDoListDal toDoListDal)
		{
			_toDoListDal = toDoListDal;
		}

		public void TAdd(ToDoList t)
		{
			throw new NotImplementedException();
		}

		public void TDelete(ToDoList t)
		{
			throw new NotImplementedException();
		}

		public void TUpdate(ToDoList t)
		{
			throw new NotImplementedException();
		}

		public List<ToDoList> GetList()
		{
			return _toDoListDal.GetList();
		}

		public ToDoList GetById(int id)
		{
			throw new NotImplementedException();
		}

		public List<ToDoList> TGetListByFilter()
		{
			throw new NotImplementedException();
		}
	}
}
