using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyBlog.Business.Abstract;
using MyBlog.Business.Constants;
using MyBlog.Business.ValidationRules.FluentValidation;
using MyBlog.Core.Aspects.Autofac.Caching;
using MyBlog.Core.Aspects.Autofac.Validation;
using MyBlog.Core.Utilities.Results.Abstract;
using MyBlog.Core.Utilities.Results.Concrete;
using MyBlog.DataAccess.Abstract;
using MyBlog.Entities.Concrete;

namespace MyBlog.Business.Concrete.Managers
{
	public class CategoryManager : ICategoryService
	{
		private ICategoryDal _categoryDal;

		public CategoryManager(ICategoryDal categoryDal)
		{
			_categoryDal = categoryDal;
		}

		[ValidationAspect(typeof(CategoryValidator), Priority = 1)]
		[CacheRemoveAspect("ICategoryService.Get", Priority = 2)]
		public IResult Add(Category category)
		{
			_categoryDal.Add(category);
			return new SuccessResult(Messages.CategoryAdded);
		}

		[CacheAspect()]
		public IDataResult<List<Category>> GetAll()
		{
			return new SuccessDataResult<List<Category>>(_categoryDal.GetList().ToList());
		}
	}
}
