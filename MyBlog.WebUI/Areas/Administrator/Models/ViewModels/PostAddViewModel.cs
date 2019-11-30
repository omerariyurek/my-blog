using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos;

namespace MyBlog.WebUI.Areas.Administrator.Models.ViewModels
{
	public class PostAddViewModel
	{
		public List<SelectListItem> Categories { get; set; }
		public List<SelectListItem> Tags { get; set; }
		public PostDto PostDto { get; set; }
	}
}
