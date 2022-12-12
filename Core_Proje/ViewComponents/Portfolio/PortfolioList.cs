using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Portfolio
{
	public class PortfolioList : ViewComponent
	{
		IPortfolioService _portfolioService;

		public PortfolioList(IPortfolioService portfolioService)
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
