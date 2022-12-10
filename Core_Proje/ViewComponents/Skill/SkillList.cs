using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Skill
{
	public class SkillList : ViewComponent
	{
		ISkillService _skillService;

		public SkillList(ISkillService skillService)
		{
			_skillService = skillService;
		}
		public IViewComponentResult Invoke()
		{
			var values = _skillService.GetList();
			return View(values);
		}
	}
}
