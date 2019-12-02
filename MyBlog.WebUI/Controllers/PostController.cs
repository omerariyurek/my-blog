using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyBlog.Business.Abstract;
using MyBlog.WebUI.Models.ViewModels;

namespace MyBlog.WebUI.Controllers
{
	public class PostController : Controller
	{
		private IPostService _postService;

		public PostController(IPostService postService)
		{
			_postService = postService;
		}

		[HttpGet("/posts")]
		public IActionResult Index()
		{
			var model = _postService.GetPostDetails().Data;
			return View(model);
		}

		[HttpGet("/post/{seoUrl}")]
		public IActionResult Get(string seoUrl)
		{
			if (!string.IsNullOrEmpty(seoUrl))
			{
				var postId = _postService.GetByUrl(seoUrl).Data;
				var model = new PostGetViewModel
				{
					PostTags = _postService.GetPostTags(postId).Data,
					PostDetail = _postService.GetPostDetail(postId).Data
				};
				return View(model);
			}
			return RedirectToAction("PageNotFound", "Error");
		}
	}
}