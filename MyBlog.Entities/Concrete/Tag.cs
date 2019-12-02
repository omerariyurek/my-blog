using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using MyBlog.Core.Entities.Abstract;

namespace MyBlog.Entities.Concrete
{
	public class Tag : IEntity
	{
		public Tag()
		{
			CreatedDate = DateTime.Now;
		}
		public int TagId { get; set; }
		public string TagName { get; set; }
		public string SeoUrl { get; set; }
		public string MetaDescription { get; set; }
		public string MetaKeywords { get; set; }
		public DateTime CreatedDate { get; set; }
		public bool Status { get; set; }
	}
}
