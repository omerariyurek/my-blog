using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using MyBlog.Entities.Concrete;

namespace MyBlog.Business.ValidationRules.FluentValidation
{
	public class PostValidator : AbstractValidator<Post>
	{
		public PostValidator()
		{
			RuleFor(x => x.PostId).NotEmpty();
			RuleFor(x => x.Title).NotEmpty();
			RuleFor(x => x.Status).NotEmpty();
		}
	}
}
