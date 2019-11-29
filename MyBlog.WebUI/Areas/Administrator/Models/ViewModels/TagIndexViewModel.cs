using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyBlog.Entities.Concrete;

namespace MyBlog.WebUI.Areas.Administrator.Models.ViewModels
{
	public class TagIndexViewModel
	{
		public Tag Tag { get; set; }
		public List<Tag> Tags { get; set; }
		public int PageSize { get; set; }
		public int PageCount { get; set; }
		public int CurrentPage { get; set; }
		public string SearchTag { get; set; }
	}
}
