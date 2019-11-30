using System;
using System.Collections.Generic;
using System.Text;
using MyBlog.Core.Entities.Abstract;

namespace MyBlog.Entities.Dtos
{
	public class PostDto : IDto
	{
		public PostDto()
		{
			CreatedDate = DateTime.Now;
		}
		public int PostId { get; set; }
		public string Title { get; set; }
		public string Content { get; set; }
		public string SeoUrl { get; set; }
		public bool Status { get; set; }
		public bool CommentStatus { get; set; }
		public bool IsHome { get; set; }
		public DateTime CreatedDate { get; set; }
		public DateTime? ModifiedDate { get; set; }
		public string MetaDescription { get; set; }
		public string MetaKeywords { get; set; }
		public string[] Categories { get; set; }
		public string[] Tags { get; set; }
	}
}
