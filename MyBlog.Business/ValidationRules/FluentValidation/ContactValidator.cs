using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using FluentValidation;
using MyBlog.Entities.Concrete;

namespace MyBlog.Business.ValidationRules.FluentValidation
{
	public class ContactValidator : AbstractValidator<Contact>
	{
		public ContactValidator()
		{
			RuleFor(x => x.Message).NotEmpty().WithMessage("Lütfen mesajınızı giriniz.");
			RuleFor(x => x.ContactName).NotEmpty().WithMessage("Adınızı ve soyadınızı giriniz.");
			RuleFor(x => x.Email).NotEmpty().WithMessage("E-Mail adresinizi giriniz.");
			RuleFor(x => x.Subject).NotEmpty().WithMessage("İletişim konusunu giriniz.");

		}
	}
}
