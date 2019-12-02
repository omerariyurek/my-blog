using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using System.Threading;
using MyBlog.Core.Entities.Abstract;

namespace MyBlog.Entities.Concrete
{
	public class Category : IEntity
	{
		public Category()
		{
			CreatedDate = DateTime.Now;
		}
		public int CategoryId { get; set; }
		public string CategoryName { get; set; }
		public string CategoryDescription { get; set; }
		public string MetaDescription { get; set; }
		public string MetaKeywords { get; set; }
		public string SeoUrl { get; set; }
		public DateTime CreatedDate { get; set; }
		public bool Status { get; set; }
	}
}
