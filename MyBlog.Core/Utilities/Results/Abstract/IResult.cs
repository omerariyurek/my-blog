using System;
using System.Collections.Generic;
using System.Text;

namespace MyBlog.Core.Utilities.Results.Abstract
{
	public interface IResult
	{
		bool Success { get; }
		string Message { get; }
	}
}
