using System;
using System.Collections.Generic;
using System.Text;
using MyBlog.Core.Entities.Abstract;

namespace MyBlog.Entities.Dtos
{
	public class PostTagsDto : IDto
	{
		public int PostId { get; set; }
		public int TagId { get; set; }
		public string TagName { get; set; }
		public string SeoUrl { get; set; }
	}
}
