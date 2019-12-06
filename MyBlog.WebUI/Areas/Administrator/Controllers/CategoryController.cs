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
		public IActionResult Index(string search, int page = 1)
		{
			int pageSize = 5;
			var categories = _categoryService.GetAll().Data;
			if (!string.IsNullOrEmpty(search))
			{
				categories = categories.Where(x => x.CategoryName.Contains(search)).ToList();
				TempData.Add("searchCategory", search);
			}
			var model = new CategoryIndexViewModel
			{
				Categories = categories.Skip((page - 1) * pageSize).Take(pageSize).ToList(),
				Category = new Category(),
				PageCount = (int)Math.Ceiling(categories.Count / (double)pageSize),
				PageSize = pageSize,
				CurrentPage = page,
				SearchCategory = search
			};
			return View(model);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Add(Category category)
		{
			var categoryAddOperation = _categoryService.Add(category);
			TempData.Add(!categoryAddOperation.Success ? "Error" : "Success", categoryAddOperation.Message);
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
		[ValidateAntiForgeryToken]
		public IActionResult Update(Category category)
		{
			var categoryUpdateOperation = _categoryService.Update(category);
			TempData.Add(!categoryUpdateOperation.Success ? "Error" : "Success", categoryUpdateOperation.Message);
			return RedirectToAction("Index");
		}
	}
}