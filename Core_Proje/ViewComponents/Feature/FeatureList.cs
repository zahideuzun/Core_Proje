using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Feature
{
    public class FeatureList: ViewComponent
    {
        private readonly IFeatureService _featureService;

        public FeatureList(IFeatureService featureService)
        {
                _featureService= featureService;
        }
        
        public IViewComponentResult Invoke()
        {
            var values = _featureService.GetList();
            return View(values);
        }
    }
}
