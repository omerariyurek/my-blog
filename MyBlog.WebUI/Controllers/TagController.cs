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

		[HttpGet("/tags/{page=1}")]
	    public IActionResult Index(int page=1)
	    {
		    int pageSize = 6;
		    var tags = _tagService.GetListActive().Data;
		    var model = new TagIndexViewModel
		    {
				Tags = tags.Skip((page - 1) * pageSize).Take(pageSize).ToList(),
				PageCount = (int)Math.Ceiling(tags.Count / (double)pageSize),
				CurrentPage = page,
				PageSize = pageSize
			};
            return View(model);
        }

	    [HttpGet("/tag/{seoUrl}/{page=1}")]
	    public IActionResult TagPosts(string seoUrl,int page=1)
	    {
		    int pageSize = 5;
		    var tag = _tagService.GetByUrl(seoUrl).Data;
		    if (tag == null)
		    {
			    return RedirectToAction("PageNotFound", "Error");
		    }

		    var tagPosts = _postService.GetTagPosts(tag.TagId).Data;
		    var model = new TagPostsViewModel
		    {
			    Tag = tag,
			    PostDetails = tagPosts.Skip((page - 1) * pageSize).Take(pageSize).ToList(),
				PageCount = (int)Math.Ceiling(tagPosts.Count / (double)pageSize),
				CurrentPage = page,
				PageSize = pageSize,
				CurrentTag = seoUrl
			};
			return View(model);
	    }
    }
}