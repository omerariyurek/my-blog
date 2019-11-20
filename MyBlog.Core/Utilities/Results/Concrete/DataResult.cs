using System;
using System.Collections.Generic;
using System.Text;
using MyBlog.Core.Utilities.Results.Abstract;

namespace MyBlog.Core.Utilities.Results.Concrete
{
	public class DataResult<T> : Result, IDataResult<T>
	{
		public DataResult(T data, bool success, string message) : base(success, message)
		{
			Data = data;
		}

		public DataResult(T data, bool success):base(success)
		{
			Data = data;
		}

		public T Data { get; }
	}
}
