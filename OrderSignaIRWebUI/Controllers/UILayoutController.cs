using Microsoft.AspNetCore.Mvc;

namespace OrderSignaIRWebUI.Controllers
{
    public class UILayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
