using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MyBlog.Business.DependencyResolvers.Autofac;
using MyBlog.Core.DependencyResolvers;
using MyBlog.Core.Extensions;
using MyBlog.Core.Utilities.IoC;

namespace MyBlog.WebUI
{
	public class Startup
	{
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddMvc().AddFluentValidation();
			services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
				.AddCookie(options =>
				{
					options.LoginPath = "/Administrator/Auth/Login/";
				});
			services.AddHttpContextAccessor();
			services.AddDependencyResolvers(new ICoreModule[]
			{
				new CoreModule()
			});
		}

		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
				//app.UseExceptionHandler("/error");
				//app.UseStatusCodePagesWithReExecute("/error/{0}");
			}
			else
			{
				app.UseExceptionHandler("/error");
				app.UseStatusCodePagesWithReExecute("/error/{0}");
				app.UseHsts();
			}
			app.UseFileServer();
			app.UseFiles(env.ContentRootPath, "node_modules", "/node_modules");
			app.UseFiles(env.ContentRootPath, "content", "/content");
			app.UseRouting();
			app.UseAuthentication();
			app.UseAuthorization();
			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllerRoute(
					name: "areas",
					"{area:exists}/{controller=Home}/{action=Index}/{id?}"
				);
				endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
			});
		}
	}
}