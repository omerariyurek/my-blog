using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MyBlog.Core.DependencyResolvers;
using MyBlog.Core.Extensions;
using MyBlog.Core.Utilities.IoC;
using MyBlog.WebUI.Middlewares;

namespace MyBlog.WebUI
{
	public class Startup
	{
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddMvc();
			services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
				.AddCookie(options =>
				{
					options.LoginPath = "/Administrator/Auth/Login/";
				});

			services.AddHttpContextAccessor();
			//services.AddMvc().AddFluentValidation(provider =>
			//{
			//	provider.ValidatorFactory = new 
			//});
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
			app.UseNodeModules(env.ContentRootPath);
			app.UseStyleFiles(env.ContentRootPath);
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