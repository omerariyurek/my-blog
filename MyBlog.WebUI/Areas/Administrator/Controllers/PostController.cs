using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Castle.Components.DictionaryAdapter;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyBlog.Business.Abstract;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos;
using MyBlog.WebUI.Areas.Administrator.Models.ViewModels;

namespace MyBlog.WebUI.Areas.Administrator.Controllers
{
	[Area("Administrator")]
	[Authorize]
	public class PostController : Controller
	{
		private IPostService _postService;
		private ITagService _tagService;
		private ICategoryService _categoryService;

		public PostController(IPostService postService, ITagService tagService, ICategoryService categoryService)
		{
			_postService = postService;
			_tagService = tagService;
			_categoryService = categoryService;
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

		[HttpGet("administrator/post/add")]
		public IActionResult Add()
		{
			var tags = _tagService.GetListActive().Data;
			var categories = _categoryService.GetListActive().Data;
			var model = new PostAddViewModel
			{
				Tags = new List<SelectListItem>(),Categories = new List<SelectListItem>(),PostDto = new PostDto()
			};
			foreach (var tag in tags)
			{
				model.Tags.Add(new SelectListItem
				{
					Value = tag.TagId.ToString(),
					Text = tag.TagName
				});
			}
			foreach (var category in categories)
			{
				model.Categories.Add(new SelectListItem
				{
					Value = category.CategoryId.ToString(),
					Text = category.CategoryName
				});
			}
			return View(model);
		}

		[HttpPost]
		public IActionResult Add(PostDto postDto)
		{
			return View();
		}

		[HttpGet("administrator/post/update")]
		public IActionResult Update(int id)
		{
			var post = _postService.GetById(id).Data;
			var model = new PostUpdateViewModel
			{
				Post = post
			};
			return View(model);
		}

		[HttpPost]
		public IActionResult Update(Post post)
		{
			return View();
		}

		[HttpPost]
		public IActionResult Delete(int id)
		{
			var deleteOperation = _postService.Delete(id);
			return Json(deleteOperation.Message);
		}

	}
}