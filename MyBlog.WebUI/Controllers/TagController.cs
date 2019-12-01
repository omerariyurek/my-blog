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

	    public TagController(ITagService tagService)
	    {
		    _tagService = tagService;
	    }

		[HttpGet("/etiketler")]
	    public IActionResult Index()
	    {
		    var tags = _tagService.GetListActive().Data;
		    var model = new TagIndexViewModel
		    {
				Tags = tags
		    };
            return View(model);
        }
    }
}