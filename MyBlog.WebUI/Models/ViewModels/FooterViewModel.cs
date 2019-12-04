using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyBlog.Entities.Concrete;

namespace MyBlog.WebUI.Models.ViewModels
{
	public class FooterViewModel
	{
		public List<Category> Categories { get; set; }
		public List<Tag> Tags { get; set; }

	}
}
