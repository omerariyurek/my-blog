using System;
using System.Collections.Generic;
using System.Text;
using MyBlog.Core.Utilities.Results.Abstract;
using MyBlog.Entities.Concrete;

namespace MyBlog.Business.Abstract
{
	public interface ICategoryService
	{
		IResult Add(Category category);
		IDataResult<List<Category>> GetAll();
	}
}
