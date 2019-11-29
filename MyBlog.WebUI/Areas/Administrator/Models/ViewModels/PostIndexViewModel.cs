using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyBlog.Entities.Concrete;

namespace MyBlog.WebUI.Areas.Administrator.Models.ViewModels
{
	public class PostIndexViewModel
	{
		public Post Post { get; set; }
		public List<Post> Posts { get; set; }
		public int PageSize { get; set; }
		public int PageCount { get; set; }
		public int CurrentPage { get; set; }
		public string SearchPost { get; set; }
	}
}
