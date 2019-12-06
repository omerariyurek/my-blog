using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos;

namespace MyBlog.WebUI.Models.ViewModels
{
	public class PostGetViewModel
	{
		public PostDetailDto PostDetail { get; set; }
		public List<PostTagsDto> PostTags { get; set; }
		public List<Post> RandomTwoPosts { get; set; }
		public Comment Comment { get; set; }
		public List<Comment> Comments { get; set; }
	}
}
