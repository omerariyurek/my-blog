using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using FluentValidation;
using MyBlog.Business.ValidationRules.FluentValidation;
using MyBlog.Entities.Concrete;

namespace MyBlog.Business.DependencyResolvers.Autofac
{
	public class AutofacValidationModule : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			builder.RegisterType<PostValidator>().As<IValidator<Post>>();
		}
	}
}
