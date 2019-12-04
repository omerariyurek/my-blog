using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using MyBlog.Entities.Dtos;

namespace MyBlog.Business.ValidationRules.FluentValidation
{
	public class PostSearchValidator : AbstractValidator<PostSearchDto>
	{
		public PostSearchValidator()
		{
			RuleFor(x => x.PostName).NotEmpty().WithMessage("Lütfen aranacak kelimeyi girin");
		}
	}
}
