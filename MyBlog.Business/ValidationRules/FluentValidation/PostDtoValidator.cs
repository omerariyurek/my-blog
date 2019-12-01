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
			RuleFor(x => x.Title).NotEmpty().WithMessage("Post title is required."); ;
			RuleFor(x => x.Content).NotEmpty().WithMessage("Post content is required."); ;
			RuleFor(x => x.Status).NotEmpty();
		}
	}
}
