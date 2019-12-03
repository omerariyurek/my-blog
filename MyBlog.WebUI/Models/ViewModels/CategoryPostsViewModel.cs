using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos;

namespace MyBlog.WebUI.Models.ViewModels
{
	public class CategoryPostsViewModel
	{
		public List<PostDetailDto> PostDetails { get; set; }
		public Category Category { get; set; }
		public int PageSize { get; set; }
		public int PageCount { get; set; }
		public int CurrentPage { get; set; }
		public string CurrentCategory { get; set; }
	}
}
