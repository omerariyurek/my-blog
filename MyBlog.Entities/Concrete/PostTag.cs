using System;
using System.Collections.Generic;
using System.Text;
using MyBlog.Core.Entities.Abstract;

namespace MyBlog.Entities.Concrete
{
	public class PostTag : IEntity
	{
		public int PostTagId { get; set; }
		public int PostId { get; set; }
		public int TagId { get; set; }
		public Post Post { get; set; }
		public Tag Tag { get; set; }
	}
}
