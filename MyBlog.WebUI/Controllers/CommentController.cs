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
		private IPostService _postService;

		public CommentController(ICommentService commentService, IPostService postService)
		{
			_commentService = commentService;
			_postService = postService;
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Add(Comment comment)
		{
			comment.AuthorIpAddress = HttpContext.Connection.RemoteIpAddress.ToString();
			var addCommentOperation = _commentService.Add(comment);
			if (addCommentOperation.Success)
			{
				var post = _postService.GetById(comment.PostId).Data; // for post redirect
				TempData.Add("CommentInsertSuccessful",addCommentOperation.Message);
				return RedirectToAction("Get", "Post", new {seoUrl = post.SeoUrl});
			}
			return RedirectToAction("InternalServerError","Error");
		}
	}
}