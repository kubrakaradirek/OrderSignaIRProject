using Microsoft.AspNetCore.Mvc;

namespace OrderSignaIRWebUI.ViewComponents.LayoutComponents
{
    public class _LayoutScriptComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
