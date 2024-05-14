using Microsoft.AspNetCore.Mvc;

namespace OrderSignaIRWebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
