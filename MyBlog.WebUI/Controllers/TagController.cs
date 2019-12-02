using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyBlog.Business.Abstract;
using MyBlog.WebUI.Models.ViewModels;

namespace MyBlog.WebUI.Controllers
{
    public class TagController : Controller
    {
	    private ITagService _tagService;
	    private IPostService _postService;

	    public TagController(ITagService tagService, IPostService postService)
	    {
		    _tagService = tagService;
		    _postService = postService;
	    }

		[HttpGet("/tags")]
	    public IActionResult Index()
	    {
		    var tags = _tagService.GetListActive().Data;
		    var model = new TagIndexViewModel
		    {
				Tags = tags
		    };
            return View(model);
        }

	    [HttpGet("/tag/{seoUrl}")]
	    public IActionResult TagPosts(string seoUrl)
	    {
		    var tag = _tagService.GetByUrl(seoUrl).Data;
		    if (tag == null)
		    {
			    return RedirectToAction("PageNotFound", "Error");
		    }

		    var tagPosts = _postService.GetTagPosts(tag.TagId).Data;
		    var model = new TagPostsViewModel
		    {
			    Tag = tag,
			    PostDetails = tagPosts
		    };
			return View(model);
	    }
    }
}