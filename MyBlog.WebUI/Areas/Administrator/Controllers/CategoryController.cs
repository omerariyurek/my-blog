using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyBlog.Business.Abstract;
using MyBlog.Business.Constants;
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

		[HttpGet("administrator/categories")]
		public IActionResult Index(string search)
		{
			var categories = _categoryService.GetAll().Data;
			if (!string.IsNullOrEmpty(search))
			{
				categories = categories.Where(x => x.CategoryName.Contains(search)).ToList();
				TempData.Add("searchCategory", search);
			}
			var model = new CategoryIndexViewModel
			{
				Categories = categories,
				Category = new Category()
			};
			return View(model);
		}

		[HttpPost]
		public IActionResult Add(Category category)
		{
			_categoryService.Add(category);
			return RedirectToAction("Index");
		}

		[HttpPost]
		public IActionResult Delete(int id)
		{
			var deleteOperation = _categoryService.Delete(id);
			return Json(deleteOperation.Message);
		}

		[HttpPost]
		public IActionResult Get(int id)
		{
			var category = _categoryService.GetById(id).Data;
			return Json(category);
		}

		[HttpPost]
		public IActionResult Update(Category category)
		{
			_categoryService.Update(category);
			return RedirectToAction("Index");
		}
	}
}