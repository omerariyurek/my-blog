using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyBlog.Business.Abstract;
using MyBlog.WebUI.Areas.Administrator.Models.ViewModels;
using CategoryIndexViewModel = MyBlog.WebUI.Models.ViewModels.CategoryIndexViewModel;

namespace MyBlog.WebUI.Controllers
{
    public class CategoryController : Controller
    {
	    private ICategoryService _categoryService;

	    public CategoryController(ICategoryService categoryService)
	    {
		    _categoryService = categoryService;
	    }

	    [HttpGet("/kategoriler")]
        public IActionResult Index()
        {
	        var categories = _categoryService.GetListActive().Data;
	        var model = new CategoryIndexViewModel
	        {
				Categories = categories
	        };
	        return View(model);
        }

		[HttpGet("/kategori/{categoryName}")]
        public IActionResult CategoryPosts(string categoryName)
        {
	        return View();
        }

    }
}