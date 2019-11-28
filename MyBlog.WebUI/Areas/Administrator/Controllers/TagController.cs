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
	public class TagController : Controller
	{
		private ITagService _tagService;

		public TagController(ITagService tagService)
		{
			_tagService = tagService;
		}

		[HttpGet("administrator/tags")]
		public IActionResult Index(string search)
		{
			var tags = _tagService.GetAll().Data;
			if (!string.IsNullOrEmpty(search))
			{
				tags = tags.Where(x => x.TagName.Contains(search)).ToList();
				TempData.Add("searchTag", search);
			}
			var model = new TagIndexViewModel
			{
				Tags = tags,
				Tag =  new Tag()
			};
			return View(model);
		}

		[HttpPost]
		public IActionResult Add(Tag tag)
		{
			_tagService.Add(tag);
			return RedirectToAction("Index");
		}

		[HttpPost]
		public IActionResult Delete(int id)
		{
			var deleteOperation = _tagService.Delete(id);
			return Json(deleteOperation.Message);
		}

		[HttpPost]
		public IActionResult Get(int id)
		{
			var tag = _tagService.GetById(id).Data;
			return Json(tag);
		}

		[HttpPost]
		public IActionResult Update(Tag tag)
		{
			_tagService.Update(tag);
			return RedirectToAction("Index");
		}
	}
}