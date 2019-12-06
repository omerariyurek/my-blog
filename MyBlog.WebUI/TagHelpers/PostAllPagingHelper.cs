using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace MyBlog.WebUI.TagHelpers
{
	[HtmlTargetElement("post-all-paging")]

	public class PostAllPagingHelper : TagHelper
	{
		[HtmlAttributeName("page-size")]
		public int PageSize { get; set; }
		[HtmlAttributeName("page-count")]
		public int PageCount { get; set; }
		[HtmlAttributeName("current-page")]
		public int CurrentPage { get; set; }
		[HtmlAttributeName("search-post")]
		public string SearchPost { get; set; }

		public override void Process(TagHelperContext context, TagHelperOutput output)
		{
			output.TagName = "div";
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("<ul class='load-more__pagenation'>");
			for (int i = 1; i <= PageCount; i++)
			{
				stringBuilder.AppendFormat("<li>");
				stringBuilder.AppendFormat("<a href='/all-post?search={0}&?page={1}'class='{2}'>{3}</a>", SearchPost, i, i == CurrentPage ? "active" : "", i);
				stringBuilder.Append("</li>");
			}
			stringBuilder.Append("</ul>");
			output.Content.SetHtmlContent(stringBuilder.ToString());
			base.Process(context, output);
		}
	}
}
