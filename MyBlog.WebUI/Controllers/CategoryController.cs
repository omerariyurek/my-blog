using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyBlog.WebUI.Controllers
{
    public class CategoryController : Controller
    {
		[HttpGet("/categories")]
        public IActionResult Index()
        {
            return View();
        }
    }
}