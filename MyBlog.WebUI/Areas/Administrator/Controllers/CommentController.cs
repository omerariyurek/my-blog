using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CSharp.RuntimeBinder;
using MyBlog.Business.Abstract;
using MyBlog.Entities.Concrete;
using MyBlog.WebUI.Areas.Administrator.Models.ViewModels;

namespace MyBlog.WebUI.Areas.Administrator.Controllers
{
	[Area("Administrator")]
	[Authorize]
	public class CommentController : Controller
	{
		private ICommentService _commentService;

		public CommentController(ICommentService commentService)
		{
			_commentService = commentService;
		}

		[HttpGet("administrator/comments")]
		public IActionResult Index(string search,int page=1)
		{
			int pageSize = 7;
			var comments = _commentService.GetAll().Data;
			if (!string.IsNullOrEmpty(search))
			{
				comments = comments.Where(x => x.AuthorName.Contains(search) || x.Content.Contains(search)).ToList();
				TempData.Add("searchComment",search);
			}

			var model = new CommentIndexViewModel
			{
				Comment = new Comment(),
				Comments = comments.Skip((page - 1) * pageSize).Take(pageSize).ToList(),
				CurrentPage = page,
				PageSize = pageSize,
				SearchComment = search,
				PageCount = (int)Math.Ceiling(comments.Count / (double)pageSize)
			};
			return View(model);
		}

		[HttpPost]
		public IActionResult Delete(int id)
		{
			var deleteOperation = _commentService.Delete(id);
			return Json(deleteOperation.Message);
		}

		[HttpPost]
		public IActionResult Get(int id)
		{
			var comment = _commentService.GetById(id).Data;
			return Json(comment);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Update(Comment comment)
		{
			_commentService.Update(comment);
			return RedirectToAction("Index");
		}
	}
}