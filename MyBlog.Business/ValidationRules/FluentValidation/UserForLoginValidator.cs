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
			RuleFor(x => x.UserName).NotEmpty().WithMessage("User name is required."); 
			RuleFor(x => x.Password).NotEmpty().WithMessage("Password is required.");
			
		}
	}
}
