using System;
using System.Collections.Generic;
using System.Text;
using MyBlog.Core.Utilities.Results.Abstract;

namespace MyBlog.Core.Utilities.Business
{
	public class BusinessRules
	{
		public static IResult Run(params IResult[] logics)
		{
			foreach (var result in logics)
			{
				if (!result.Success)
				{
					return result;
				}
			}
			return null;
		}
	}
}
