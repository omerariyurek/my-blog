using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyBlog.Entities.Concrete;

namespace MyBlog.WebUI.Areas.Administrator.Models.ViewModels
{
	public class CategoryIndexViewModel
	{
		public Category Category { get; set; }
		public List<Category> Categories { get; set; }
	}
}
