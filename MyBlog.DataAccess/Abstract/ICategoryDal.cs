using System;
using System.Collections.Generic;
using System.Text;
using MyBlog.Core.DataAccess.Abstract;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos;

namespace MyBlog.DataAccess.Abstract
{
	public interface ICategoryDal : IEntityRepository<Category>
	{
		List<CategoriesDto> GetCategories();
	}
}
