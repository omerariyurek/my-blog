using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyBlog.Business.Abstract;
using MyBlog.WebUI.Models.ViewModels;

namespace MyBlog.WebUI.Controllers
{
	public class HomeController : Controller
	{
		private IPostService _postService;

		public HomeController(IPostService postService)
		{
			_postService = postService;
		}

		public IActionResult Index()
		{
			var posts = _postService.GetActiveSixPosts().Data;
			var model = new HomeIndexViewModel
			{
				Posts = posts
			};
			return View(model);
		}

	}
}