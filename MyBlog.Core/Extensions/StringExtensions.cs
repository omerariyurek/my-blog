using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace MyBlog.Core.Extensions
{
	public static class StringExtensions
	{
		public static string CreateSeoFriendlyUrl(this string text)
		{
			if (text == null) return "";
			text = text.Replace("ş", "s");
			text = text.Replace("Ş", "s");
			text = text.Replace("İ", "i");
			text = text.Replace("I", "i");
			text = text.Replace("ı", "i");
			text = text.Replace("ö", "o");
			text = text.Replace("Ö", "o");
			text = text.Replace("ü", "u");
			text = text.Replace("Ü", "u");
			text = text.Replace("Ç", "c");
			text = text.Replace("ç", "c");
			text = text.Replace("ğ", "g");
			text = text.Replace("Ğ", "g");
			text = text.Replace(" ", "-");
			text = text.Replace("---", "-");
			text = text.Replace("?", "");
			text = text.Replace("/", "");
			text = text.Replace(".", "dot");
			text = text.Replace("'", "");
			text = text.Replace("#", "sharp");
			text = text.Replace("%", "");
			text = text.Replace("&", "");
			text = text.Replace("*", "");
			text = text.Replace("!", "");
			text = text.Replace("@", "");
			text = text.Replace("+", "");
			text = text.Replace("'", "-");
			text = text.ToLower();
			text = text.Trim();
			string encodedUrl = (text ?? "").ToLower();
			encodedUrl = Regex.Replace(encodedUrl, @"\&+", "and");
			encodedUrl = encodedUrl.Replace("'", "");
			encodedUrl = Regex.Replace(encodedUrl, @"[^a-z0-9]", "-");
			encodedUrl = Regex.Replace(encodedUrl, @"-+", "-");
			encodedUrl = encodedUrl.Trim('-');
			return encodedUrl;
		}
	}
}
