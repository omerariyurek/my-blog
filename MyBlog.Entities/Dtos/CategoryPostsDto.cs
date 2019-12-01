using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using MyBlog.Core.Entities.Abstract;

namespace MyBlog.Entities.Dtos
{
	public class CategoryPostsDto : IDto
	{
		public int CategoryId { get; set; }
		public int PostId { get; set; }
		public string CategoryName { get; set; }
		public string Title { get; set; }
	}
}
