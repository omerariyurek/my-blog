using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using MyBlog.Entities.Dtos;

namespace MyBlog.Business.ValidationRules.FluentValidation
{
	public class UserForLoginValidator : AbstractValidator<UserForLoginDto>
	{
		public UserForLoginValidator()
		{
			RuleFor(x => x.UserName).NotEmpty();
			RuleFor(x => x.Password).NotEmpty();
		}
	}
}
