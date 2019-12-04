using System;
using System.Collections.Generic;
using System.Text;
using MyBlog.Core.Entities.Abstract;

namespace MyBlog.Entities.Dtos
{
	public class PostSearchDto : IDto
	{
		public string PostName { get; set; }
	}
}
