using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using MyBlog.Entities.Dtos;

namespace MyBlog.Business.ValidationRules.FluentValidation
{
	public class PostDtoValidator : AbstractValidator<PostDto>
	{
		public PostDtoValidator()
		{
			RuleFor(x => x.Title).NotEmpty();
			RuleFor(x => x.Status).NotEmpty();
		}
	}
}
