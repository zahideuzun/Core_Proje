using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Experience
{
	public class ExperienceList : ViewComponent
	{
		IExperienceService _experienceService;

		public ExperienceList(IExperienceService experienceService)
		{
			_experienceService = experienceService;
		}
		public IViewComponentResult Invoke()
		{
			var values = _experienceService.GetList();
			return View(values);
		}
	}
}
