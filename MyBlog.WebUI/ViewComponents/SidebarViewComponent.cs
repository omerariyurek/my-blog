using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using MyBlog.Entities.Dtos;


namespace MyBlog.WebUI.ViewComponents
{
	public class SidebarViewComponent : ViewComponent
	{
		public ViewViewComponentResult Invoke()
		{
			return View(new PostSearchDto());
		}
	}
}
