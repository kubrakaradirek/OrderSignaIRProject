﻿using Microsoft.AspNetCore.Mvc;

namespace OrderSignaIRWebUI.ViewComponents.LayoutComponents
{
	public class _LayoutNavbarComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
