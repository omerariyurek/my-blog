using System;
using System.Collections.Generic;
using System.Text;
using MyBlog.Core.Entities.Abstract;

namespace MyBlog.Entities.Dtos
{
	public class CategoriesDto : IDto
	{
		public int CategoryId { get; set; }
		public string CategoryName { get; set; }
		public bool Selected { get; set; }
	}
}
