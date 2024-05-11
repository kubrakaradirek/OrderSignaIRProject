using Microsoft.AspNetCore.Mvc;

namespace OrderSignaIRWebUI.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
