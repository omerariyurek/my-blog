using System;
using System.Collections.Generic;
using System.Text;
using MyBlog.Core.Entities.Abstract;

namespace MyBlog.Entities.Concrete
{
	public class Contact : IEntity
	{
		public Contact()
		{
			CreatedDate = DateTime.Now;
		}
		public int ContactId { get; set; }
		public string ContactName { get; set; }
		public string Email { get; set; }
		public string Subject { get; set; }
		public string Message { get; set; }
		public DateTime CreatedDate { get; set; }
	}
}
