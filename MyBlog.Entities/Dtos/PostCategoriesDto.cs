using System;
using System.Collections.Generic;
using System.Text;
using MyBlog.Core.Entities.Abstract;

namespace MyBlog.Entities.Dtos
{
	public class PostCategoriesDto : IDto
	{
		public int PostId { get; set; }
		public int CategoryId { get; set; }
		public string CategoryName { get; set; }
		public string SeoUrl { get; set; }
	}
}
