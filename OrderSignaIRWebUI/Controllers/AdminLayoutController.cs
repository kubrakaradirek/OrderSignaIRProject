using Microsoft.AspNetCore.Mvc;

namespace OrderSignaIRWebUI.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
