using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyBlog.Business.Abstract;
using MyBlog.Entities.Dtos;
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

		[HttpGet("/posts/{page=1}")]
		public IActionResult Index(int page = 1)
		{
			int pageSize = 5;
			var posts = _postService.GetPostDetails().Data;
			var model = new PostIndexViewModel
			{
				PostDetails = posts.Skip((page - 1) * pageSize).Take(pageSize).ToList(),
				PageCount = (int)Math.Ceiling(posts.Count / (double)pageSize),
				CurrentPage = page,
				PageSize = pageSize
			};
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
					PostDetail = _postService.GetPostDetail(postId).Data,
					RandomTwoPosts = _postService.GetRandomTwoPosts().Data
				};
				return View(model);
			}
			return RedirectToAction("PageNotFound", "Error");
		}

		[HttpGet("/list")]
		public IActionResult List(PostSearchDto postSearchDto, int page = 1)
		{
			int pageSize = 5;
			var posts = _postService.GetPostsBySearchKey(postSearchDto).Data;
			var model = new PostListViewModel
			{
				PostDetails = posts.Skip((page - 1) * pageSize).Take(pageSize).ToList(),
				PageCount = (int)Math.Ceiling(posts.Count / (double)pageSize),
				CurrentPage = page,
				PageSize = pageSize,
				SearchKey = postSearchDto.PostName
			};
			return View(model);
		}

	}
}