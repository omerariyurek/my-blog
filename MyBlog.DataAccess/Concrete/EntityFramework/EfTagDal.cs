using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyBlog.Core.DataAccess.Concrete.EntityFramework;
using MyBlog.DataAccess.Abstract;
using MyBlog.DataAccess.Concrete.EntityFramework.Contexts;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos;

namespace MyBlog.DataAccess.Concrete.EntityFramework
{
	public class EfTagDal : EfEntityRepositoryBase<Tag, BlogContext>, ITagDal
	{
		public List<TagsDto> GetsTags()
		{
			using (var context = new BlogContext())
			{
				var result = context.Tags.Select(x => new TagsDto
				{
					TagId = x.TagId,
					TagName = x.TagName
				}).ToList();
				return result;
			}
		}
	}
}
