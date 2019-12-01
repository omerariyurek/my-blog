using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos;

namespace MyBlog.WebUI.Areas.Administrator.Models.ViewModels
{
	public class PostUpdateViewModel
	{
		public PostDto PostDto { get; set; }
		public List<TagsDto> Tags { get; set; }
		public List<CategoriesDto> Categories { get; set; }
	}
}
