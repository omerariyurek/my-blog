using System;
using System.Collections.Generic;
using System.Text;
using MyBlog.Core.Entities.Abstract;

namespace MyBlog.Entities.Dtos
{
	public class UserForLoginDto : IDto
	{
		public string UserName { get; set; }
		public string Password { get; set; }
	}
}
