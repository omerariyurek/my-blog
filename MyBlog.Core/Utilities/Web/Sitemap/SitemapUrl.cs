using System;

namespace MyBlog.Core.Utilities.Web.Sitemap
{
	public class SitemapUrl
	{
		public string Url { get; set; }
		public DateTime? Modified { get; set; }
		public ChangeFrequency? ChangeFrequency { get; set; }
		public double? Priority { get; set; }
	}
	public enum ChangeFrequency
	{
		Always,
		Hourly,
		Daily,
		Weekly,
		Monthly,
		Yearly,
		Never
	}
}
