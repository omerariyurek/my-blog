using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using MyBlog.Entities.Concrete;

namespace MyBlog.Business.ValidationRules.FluentValidation
{
	public class CommentValidator : AbstractValidator<Comment>
	{
		public CommentValidator()
		{
			RuleFor(x => x.PostId).NotEmpty();
		}
	}
}
