using System;
using System.Collections.Generic;
using System.Text;
using MyBlog.Core.Entities.Abstract;

namespace MyBlog.Entities.Concrete
{
	public class PostCategory : IEntity
	{
		public int PostCategoryId { get; set; }
		public int PostId { get; set; }
		public int CategoryId { get; set; }
		public Post Post { get; set; }
		public Category Category { get; set; }
	}
}
