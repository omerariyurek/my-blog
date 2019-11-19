using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace MyBlog.Entities.Concrete
{
	public class Tag
	{
		public Tag()
		{
			CreatedDate = DateTime.Now;
		}
		public int TagId { get; set; }
		public string TagName { get; set; }
		public string SeoUrl { get; set; }
		public DateTime CreatedDate { get; set; }
		public bool Status { get; set; }
	}
}
