using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using MyBlog.Entities.Concrete;

namespace MyBlog.Business.ValidationRules.FluentValidation
{
	public class TagValidator : AbstractValidator<Tag>
	{
		public TagValidator()
		{
			RuleFor(x => x.TagName).NotEmpty().WithMessage("Tag name is required."); ;
			RuleFor(x => x.MetaKeywords).NotEmpty().WithMessage("Meta keywords is required.");
			RuleFor(x => x.MetaDescription).NotEmpty().WithMessage("Meta description is required.");
		}
	}
}
