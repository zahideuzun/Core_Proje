using Business.Abstract;
using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Evaluation;

namespace Core_Proje.ViewComponents.Dashboard
{
	public class ProjectList : ViewComponent
	{
		//private PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioDal());
		private readonly IPortfolioService _portfolioService;

		public ProjectList(IPortfolioService portfolioService)
		{
			_portfolioService = portfolioService;
		}
		public IViewComponentResult Invoke()
		{
			var values = _portfolioService.GetList();
			return View(values);
		}
	}

}
