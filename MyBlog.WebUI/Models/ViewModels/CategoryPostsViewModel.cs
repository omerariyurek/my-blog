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
	}
}
