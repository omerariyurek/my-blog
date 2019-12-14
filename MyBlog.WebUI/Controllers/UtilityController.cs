using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyBlog.Business.Abstract;
using MyBlog.Core.Utilities.Web.Sitemap;

namespace MyBlog.WebUI.Controllers
{
	public class UtilityController : Controller
	{
		private IPostService _postService;
		private ICategoryService _categoryService;
		private ITagService _tagService;

		public UtilityController(IPostService postService, ICategoryService categoryService, ITagService tagService)
		{
			_postService = postService;
			_categoryService = categoryService;
			_tagService = tagService;
		}

		[Route("/sitemap.xml")]
		public IActionResult Sitemap()
		{
			string baseUrl = "https://www.omerariyurek.com/";

			var posts = _postService.GetPostDetails().Data;
			var categories = _categoryService.GetListActive().Data;
			var tags = _tagService.GetListActive().Data;

			var latestPost = posts.OrderByDescending(x => x.CreatedDate).FirstOrDefault();
			var latestCategory = categories.OrderByDescending(x => x.CreatedDate).FirstOrDefault();
			var latestTag = tags.OrderByDescending(x => x.CreatedDate).FirstOrDefault();
			var siteMapBuilder = new SitemapBuilder();

			siteMapBuilder.AddUrl(baseUrl, modified: DateTime.UtcNow, changeFrequency: ChangeFrequency.Weekly, priority: 1.0);
			siteMapBuilder.AddUrl(baseUrl + "contact", modified: DateTime.UtcNow, changeFrequency: ChangeFrequency.Weekly, priority: 1.0);
			siteMapBuilder.AddUrl(baseUrl + "posts", modified: latestPost.CreatedDate, changeFrequency: ChangeFrequency.Weekly, priority: 1.0);
			siteMapBuilder.AddUrl(baseUrl + "categories", modified: latestCategory.CreatedDate, changeFrequency: ChangeFrequency.Weekly, priority: 1.0);
			siteMapBuilder.AddUrl(baseUrl + "posts", modified: latestTag.CreatedDate, changeFrequency: ChangeFrequency.Weekly, priority: 1.0);

			#region Posts

			foreach (var post in posts)
			{
				siteMapBuilder.AddUrl(baseUrl + "post/" + post.SeoUrl, modified: post.CreatedDate == DateTime.MinValue ? post.ModifiedDate : post.CreatedDate, changeFrequency: ChangeFrequency.Daily, priority: 0.9);
			}

			#endregion

			#region Categories

			foreach (var category in categories)
			{
				siteMapBuilder.AddUrl(baseUrl + "category/" + category.SeoUrl, modified: category.CreatedDate, changeFrequency: ChangeFrequency.Daily, priority: 0.9);
			}

			#endregion

			#region Tags

			foreach (var tag in tags)
			{
				siteMapBuilder.AddUrl(baseUrl + "tag/" + tag.SeoUrl, modified: tag.CreatedDate, changeFrequency: ChangeFrequency.Daily, priority: 0.9);
			}

			#endregion


			string xml = siteMapBuilder.ToString();
			return Content(xml, "text/xml",Encoding.UTF8);

		}

		[Route("/robots.txt")]
		public IActionResult Robots()
		{
			Response.ContentType = "text/plain";
			return View();
		}
	}
}