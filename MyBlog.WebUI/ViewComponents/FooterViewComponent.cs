using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using MyBlog.Business.Abstract;
using MyBlog.WebUI.Models.ViewModels;

namespace MyBlog.WebUI.ViewComponents
{
	public class FooterViewComponent : ViewComponent
	{
		private ICategoryService _categoryService;
		private ITagService _tagService;

		public FooterViewComponent(ICategoryService categoryService, ITagService tagService)
		{
			_categoryService = categoryService;
			_tagService = tagService;
		}

		public ViewViewComponentResult Invoke()
		{
			var model = new FooterViewModel
			{
				Categories = _categoryService.GetRandomSixCategories().Data,
				Tags = _tagService.GetRandomSixTags().Data
			};
			return View(model);
		}
	}
}
