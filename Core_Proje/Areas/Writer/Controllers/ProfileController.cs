using Core_Proje.Areas.Writer.Models;
using Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class ProfileController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public ProfileController(UserManager<WriterUser> userManeger)
        {
            _userManager = userManeger;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditViewModel model = new UserEditViewModel();
            model.Name = values.Name;
            model.Surname = values.Surname;
            model.PictureUrl = values.ImageUrl;
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel p)
        {
	        var user = await _userManager.FindByNameAsync(User.Identity.Name);
	        if (p.Picture != null)
	        {
		        var resource = Directory.GetCurrentDirectory(); // resmin kaynagi
                var extension = Path.GetExtension(p.Picture.FileName); // parametreden gelen dosya adini al 
                var imagename=Guid.NewGuid() + extension; // benzersiz bir resim ismi olustursun guid ile. uzantidan gelen ismi de eklesin.
                var savelocation = resource + "/wwwroot/userimage/" + imagename; // resmin kaydedilecegi yer.
                var stream = new FileStream(savelocation, FileMode.Create);
                await p.Picture.CopyToAsync(stream);
                user.ImageUrl = imagename;
	        }
            
            user.Name = p.Name;
            user.Surname =p.Surname;
            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
	            return RedirectToAction("Index", "Default");
            }
            return View();
        }
    }
}
