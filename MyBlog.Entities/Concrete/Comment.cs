using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection.Metadata;
using System.Text;
using MyBlog.Core.Entities.Abstract;

namespace MyBlog.Entities.Concrete
{
	public class Comment : IEntity
	{
		public Comment()
		{
			CreatedDate = DateTime.Now;
		}
		public int CommentId { get; set; }
		public int PostId { get; set; }
		public string AuthorName { get; set; }
		public string AuthorEmail { get; set; }
		public string AuthorIpAddress { get; set; }
		public DateTime CreatedDate { get; set; }
		public bool Approved { get; set; }
		public int? ParentComment { get; set; }
		public Post Post { get; set; }
	}
}
