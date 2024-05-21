using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OrderSignaIR.EntityLayer.Entities;
using OrderSignaIRWebUI.Dtos.IdentityDtos;

namespace OrderSignaIRWebUI.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(RegisterDto registerDto)
        {
            var appUser = new AppUser()
            {
                Name = registerDto.Name,
                Surname = registerDto.SurName,
                Email = registerDto.Mail,
                UserName = registerDto.UserName
            };
            var result=await _userManager.CreateAsync(appUser,registerDto.Password); 
            if(result.Succeeded)
            {
                return RedirectToAction("Index","Login");
            }
            return View();
        }
    }
}
