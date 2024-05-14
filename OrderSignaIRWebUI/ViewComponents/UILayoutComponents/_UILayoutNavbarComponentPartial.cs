using Microsoft.AspNetCore.Mvc;

namespace OrderSignaIRWebUI.ViewComponents.UILayoutComponents
{
    public class _UILayoutNavbarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
