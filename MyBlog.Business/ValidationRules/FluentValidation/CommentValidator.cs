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
			RuleFor(x => x.AuthorName).NotEmpty().WithMessage("Lütfen adınızı ve soyadınızı giriniz.");
			RuleFor(x => x.AuthorEmail).NotEmpty().WithMessage("Lütfen e-mail adresinizi giriniz.");
			RuleFor(x => x.AuthorEmail).EmailAddress().WithMessage("Lütfen geçerli bir e-mail adresi giriniz.");
			RuleFor(x => x.Content).NotEmpty().WithMessage("Lütfen yorumunuzu giriniz.");
		}
	}
}
