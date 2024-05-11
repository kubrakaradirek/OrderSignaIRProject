using Microsoft.AspNetCore.Mvc;

namespace OrderSignaIRWebUI.ViewComponents.LayoutComponents
{
    public class _LayoutHeaderComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
