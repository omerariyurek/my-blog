using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using FluentValidation;
using MyBlog.Business.ValidationRules.FluentValidation;
using MyBlog.Core.Utilities.Interceptors.Autofac;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos;

namespace MyBlog.Business.DependencyResolvers.Autofac
{
	public class AutofacValidationModule : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			builder.RegisterType<PostDtoValidator>().As<IValidator<PostDto>>();
			builder.RegisterType<UserForLoginValidator>().As<IValidator<UserForLoginDto>>();
			builder.RegisterType<CategoryValidator>().As<IValidator<Category>>();
			builder.RegisterType<TagValidator>().As<IValidator<Tag>>();
			builder.RegisterType<CommentValidator>().As<IValidator<Comment>>();
			builder.RegisterType<ContactValidator>().As<IValidator<Contact>>();
			builder.RegisterType<PostSearchValidator>().As<IValidator<PostSearchDto>>();
		}
	}
}
