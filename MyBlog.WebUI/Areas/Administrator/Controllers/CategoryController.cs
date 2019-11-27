using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyBlog.Business.Abstract;
using MyBlog.Entities.Concrete;
using MyBlog.WebUI.Areas.Administrator.Models.ViewModels;

namespace MyBlog.WebUI.Areas.Administrator.Controllers
{
	[Area("Administrator")]
	[Authorize]
	public class CategoryController : Controller
	{
		private ICategoryService _categoryService;

		public CategoryController(ICategoryService categoryService)
		{
			_categoryService = categoryService;
		}

		[Route("administrator/category")]
		[HttpGet]
        public IActionResult Index()
        {
	        var model = new CategoryIndexViewModel
	        {
				Categories = _categoryService.GetAll().Data,
				Category = new Category()
	        };
            return View(model);
        }

        [HttpPost]
        public IActionResult CategoryAdd(Category category)
        {
	        _categoryService.Add(category);
	        return RedirectToAction("Index");
        }
	}
}