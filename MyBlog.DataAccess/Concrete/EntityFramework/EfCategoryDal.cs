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
	public class EfCategoryDal : EfEntityRepositoryBase<Category,BlogContext>,ICategoryDal
	{
		public List<CategoriesDto> GetCategories()
		{
			using (var context = new BlogContext())
			{
				var result = context.Categories.Select(x => new CategoriesDto
				{
					CategoryId = x.CategoryId,
					CategoryName = x.CategoryName
				}).ToList();
				return result;
			}
		}
	}
}
