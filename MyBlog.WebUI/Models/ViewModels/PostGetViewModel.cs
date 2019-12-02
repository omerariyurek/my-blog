using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyBlog.Entities.Dtos;

namespace MyBlog.WebUI.Models.ViewModels
{
	public class PostGetViewModel
	{
		public PostDetailDto PostDetail { get; set; }
		public List<PostTagsDto> PostTags { get; set; }
	}
}
