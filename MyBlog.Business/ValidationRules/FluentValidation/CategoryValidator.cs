using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using MyBlog.Entities.Concrete;

namespace MyBlog.Business.ValidationRules.FluentValidation
{
	public class CategoryValidator : AbstractValidator<Category>
	{
		public CategoryValidator()
		{
			RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Category name is required."); ;
		}
	}
}
