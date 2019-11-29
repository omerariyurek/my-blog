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
	public class PostController : Controller
	{
		private IPostService _postService;

		public PostController(IPostService postService)
		{
			_postService = postService;
		}


		[HttpGet("administrator/posts")]
		public IActionResult Index(string search, int page = 1)
		{
			int pageSize = 10;
			var posts = _postService.GetList().Data;
			if (!string.IsNullOrEmpty(search))
			{
				posts = posts.Where(x => x.Title.Contains(search) || x.Content.Contains(search)).ToList();
				TempData.Add("searchPost", search);
			}
			var model = new PostIndexViewModel
			{
				Post = new Post(),
				Posts = posts.Skip((page - 1) * pageSize).Take(pageSize).ToList(),
				PageCount = (int)Math.Ceiling(posts.Count / (double)pageSize),
				CurrentPage = page,
				PageSize = pageSize,
				SearchPost = search
			};

			return View(model);
		}
	}
}