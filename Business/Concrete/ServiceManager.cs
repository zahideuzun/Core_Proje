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
	public class ServiceManager : IServiceService
	{
		private IServiceDal _serviceDal;
		public ServiceManager(IServiceDal serviceDal)
		{
			_serviceDal = serviceDal;
		}

		public void TAdd(Service t)
		{
			_serviceDal.Insert(t);
		}

		public void TDelete(Service t)
		{
			_serviceDal.Delete(t);
		}

		public void TUpdate(Service t)
		{
			_serviceDal.Update(t);
		}

		public List<Service> GetList()
		{
			return _serviceDal.GetList();
		}

		public Service GetById(int id)
		{
			return _serviceDal.GetById(id);
		}
	}
}