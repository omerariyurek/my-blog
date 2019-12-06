using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyBlog.Business.Abstract;
using MyBlog.Entities.Concrete;

namespace MyBlog.WebUI.Controllers
{
	public class CommentController : Controller
	{
		private ICommentService _commentService;

		public CommentController(ICommentService commentService)
		{
			_commentService = commentService;
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Add(Comment comment)
		{
			comment.AuthorIpAddress = HttpContext.Connection.RemoteIpAddress.ToString();
			var addCommentOperation = _commentService.Add(comment);
			return RedirectToAction("Index","Post");
		}
	}
}