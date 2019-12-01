using System;
using System.Collections.Generic;
using System.Text;
using MyBlog.Core.DataAccess.Abstract;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos;

namespace MyBlog.DataAccess.Abstract
{
	public interface ITagDal : IEntityRepository<Tag>
	{
		List<TagsDto> GetsTags();
	}
}
