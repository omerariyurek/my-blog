using System.IO;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.FileProviders;

namespace MyBlog.Core.Extensions
{
	public static class ApplicationBuilderExtensions
	{
		public static IApplicationBuilder UseFiles(this IApplicationBuilder app, string root,string fileName,string requestPath)
		{
			var path = Path.Combine(root, fileName);
			var provider = new PhysicalFileProvider(path);
			var options = new StaticFileOptions();
			options.RequestPath = requestPath;
			options.FileProvider = provider;
			app.UseStaticFiles(options);
			return app;
		}
	}
}
