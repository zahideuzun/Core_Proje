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
	public class PortfolioManager : IPortfolioService
	{
		private IPortfolioDal _portfolioDal;
		public PortfolioManager(IPortfolioDal portfolioDal)
		{
			_portfolioDal = portfolioDal;
		}
		public void TAdd(Portfolio t)
		{
			_portfolioDal.Insert(t);
		}

		public void TDelete(Portfolio t)
		{
			_portfolioDal.Delete(t);
		}

		public void TUpdate(Portfolio t)
		{
			_portfolioDal.Update(t);
		}

		public List<Portfolio> GetList()
		{
			return _portfolioDal.GetList();
		}

		public Portfolio GetById(int id)
		{
			return _portfolioDal.GetById(id);
		}
	}
}
