using System;
using System.Collections.Generic;
using System.Text;
using MyBlog.Core.Utilities.Results.Abstract;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos;

namespace MyBlog.Business.Abstract
{
	public interface ICategoryService
	{
		IResult Add(Category category);
		IResult Update(Category category);
		IDataResult<Category> GetById(int categoryId);
		IDataResult<Category> GetByCategoryName(string categoryName);
		IResult Delete(int categoryId);
		IDataResult<List<Category>> GetAll();
		IDataResult<List<Category>> GetListActive();
		IDataResult<List<CategoriesDto>> GetCategories();
		IResult CheckIfCategoryNameExists(string categoryName);
	}
}
