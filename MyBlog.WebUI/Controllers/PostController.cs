using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyBlog.Business.Abstract;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos;
using MyBlog.WebUI.Models.ViewModels;

namespace MyBlog.WebUI.Controllers
{
	public class PostController : Controller
	{
		private IPostService _postService;
		private ICommentService _commentService;

		public PostController(IPostService postService, ICommentService commentService)
		{
			_postService = postService;
			_commentService = commentService;
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
			var post = _postService.GetByUrl(seoUrl).Data;
			if (post == null)
			{
				return RedirectToAction("PageNotFound", "Error");
			}
			var model = new PostGetViewModel
			{
				PostTags = _postService.GetPostTags(post.PostId).Data,
				PostDetail = _postService.GetPostDetail(post.PostId).Data,
				RandomTwoPosts = _postService.GetRandomTwoPosts().Data,
				Comment = new Comment(),
				Comments = _commentService.GetByPostId(post.PostId).Data
			};
			return View(model);
		}

		[HttpGet("/all-post")]
		public IActionResult List(string search, int page = 1)
		{
			if (!string.IsNullOrEmpty(search))
			{
				int pageSize = 5;
				var posts = _postService.GetPostsBySearchKey(search).Data;
				var model = new PostListViewModel
				{
					PostDetails = posts.Skip((page - 1) * pageSize).Take(pageSize).ToList(),
					PageCount = (int)Math.Ceiling(posts.Count / (double)pageSize),
					CurrentPage = page,
					PageSize = pageSize,
					SearchKey = search
				};
				TempData.Add("searchPost", search);
				return View(model);
			}
			return RedirectToAction("Index", "Post");
		}

	}
}