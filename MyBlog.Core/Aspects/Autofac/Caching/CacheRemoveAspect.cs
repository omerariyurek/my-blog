using System;
using System.Collections.Generic;
using System.Text;
using Castle.DynamicProxy;
using Microsoft.Extensions.DependencyInjection;
using MyBlog.Core.CrossCuttingConcerns.Caching.Abstract;
using MyBlog.Core.Utilities.Interceptors.Autofac;
using MyBlog.Core.Utilities.IoC;

namespace MyBlog.Core.Aspects.Autofac.Caching
{
	public class CacheRemoveAspect : MethodInterception
	{
		private string _pattern;
		private ICacheManager _cacheManager;

		public CacheRemoveAspect(string pattern)
		{
			_pattern = pattern;
			_cacheManager = ServiceTool.ServiceProvider.GetService<ICacheManager>();
		}

		protected override void OnSuccess(IInvocation invocation)
		{
			_cacheManager.RemoveByPattern(_pattern);
		}
	}
}