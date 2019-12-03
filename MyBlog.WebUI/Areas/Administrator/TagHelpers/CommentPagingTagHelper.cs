using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace MyBlog.WebUI.Areas.Administrator.TagHelpers
{
	[HtmlTargetElement("comment-paging")]
	public class CommentPagingTagHelper : TagHelper
	{
		[HtmlAttributeName("page-size")]
		public int PageSize { get; set; }
		[HtmlAttributeName("page-count")]
		public int PageCount { get; set; }
		[HtmlAttributeName("current-page")]
		public int CurrentPage { get; set; }
		[HtmlAttributeName("search-comment")]
		public string SearchComment { get; set; }

		public override void Process(TagHelperContext context, TagHelperOutput output)
		{
			output.TagName = "div";
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("<nav style='display:inline-block;'>");
			stringBuilder.Append("<ul class='pagination'>");
			for (int i = 1; i <= PageCount; i++)
			{
				stringBuilder.AppendFormat("<li class='{0}'>", i == CurrentPage ? "page-item active" : "");
				stringBuilder.AppendFormat("<a href='/administrator/comments?page={0}&search={1}'class='page-link page-link-test'>{2}</a>", i, SearchComment, i);
				stringBuilder.Append("</li>");
			}
			stringBuilder.Append("</ul>");
			output.Content.SetHtmlContent(stringBuilder.ToString());
			base.Process(context, output);
		}
	}
}
