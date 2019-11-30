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
		IResult Update(Category category);
		IDataResult<Category> GetById(int categoryId);
		IResult Delete(int categoryId);
		IDataResult<List<Category>> GetAll();
		IDataResult<List<Category>> GetListActive();
		IResult CheckIfCategoryNameExists(string categoryName);
	}
}
