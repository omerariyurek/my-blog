using System;
using System.Collections.Generic;
using System.Text;
using MyBlog.Core.Entities.Abstract;

namespace MyBlog.Entities.Dtos
{
	public class TagsDto : IDto
	{
		public int TagId { get; set; }
		public string TagName { get; set; }
		public bool Selected { get; set; }
	}
}
