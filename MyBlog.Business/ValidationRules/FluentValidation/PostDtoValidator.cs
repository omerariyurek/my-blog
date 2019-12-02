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
			RuleFor(x => x.Status).NotEmpty().WithMessage("Status is requried.");
			RuleFor(x => x.CommentStatus).NotEmpty().WithMessage("Comment status is requried");
			RuleFor(x => x.IsHome).NotEmpty().WithMessage("Homepage option is requried.");
			RuleFor(x => x.MetaKeywords).NotEmpty().WithMessage("Meta keywords is required.");
			RuleFor(x => x.MetaDescription).NotEmpty().WithMessage("Meta description is required.");
		}
	}
}
