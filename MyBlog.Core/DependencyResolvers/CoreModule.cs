using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using MyBlog.Core.CrossCuttingConcerns.Caching.Abstract;
using MyBlog.Core.CrossCuttingConcerns.Caching.Microsoft;
using MyBlog.Core.Utilities.IoC;

namespace MyBlog.Core.DependencyResolvers
{
	public class CoreModule : ICoreModule
	{
		public void Load(IServiceCollection services)
		{
			services.AddMemoryCache();
			services.AddSingleton<ICacheManager, MemoryCacheManager>();
		}
	}
}
