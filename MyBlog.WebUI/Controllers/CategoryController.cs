using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyBlog.Business.Abstract;
using MyBlog.WebUI.Areas.Administrator.Models.ViewModels;
using MyBlog.WebUI.Models.ViewModels;
using CategoryIndexViewModel = MyBlog.WebUI.Models.ViewModels.CategoryIndexViewModel;

namespace MyBlog.WebUI.Controllers
{
	public class CategoryController : Controller
	{
		private ICategoryService _categoryService;
		private IPostService _postService;

		public CategoryController(ICategoryService categoryService, IPostService postService)
		{
			_categoryService = categoryService;
			_postService = postService;
		}

		[HttpGet("/categories/{page=1}")]
		public IActionResult Index(int page = 1)
		{
			int pageSize = 6;
			var categories = _categoryService.GetListActive().Data;
			var model = new CategoryIndexViewModel
			{
				Categories = categories.Skip((page - 1) * pageSize).Take(pageSize).ToList(),
				PageCount = (int)Math.Ceiling(categories.Count / (double)pageSize),
				PageSize = pageSize,
				CurrentPage = page
			};
			return View(model);
		}

		[HttpGet("/category/{seoUrl}/{page=1}")]
		public IActionResult CategoryPosts(string seoUrl, int page = 1)
		{
			int pageSize = 5;
			var category = _categoryService.GetByCategoryName(seoUrl).Data;
			if (category == null)
			{
				return RedirectToAction("PageNotFound", "Error");
			}
			var categoryPosts = _postService.GetCategoryPosts(category.CategoryId).Data;
			var model = new CategoryPostsViewModel
			{
				Category = category,
				PostDetails = categoryPosts.Skip((page - 1) * pageSize).Take(pageSize).ToList(),
				PageCount = (int)Math.Ceiling(categoryPosts.Count / (double)pageSize),
				CurrentPage = page,
				PageSize = pageSize,
				CurrentCategory = seoUrl
			};
			return View(model);
		}

	}
}