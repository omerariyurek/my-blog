using System;
using System.Collections.Generic;
using System.Text;
using MyBlog.Core.Utilities.Results.Abstract;
using MyBlog.Entities.Concrete;

namespace MyBlog.Business.Abstract
{
	public interface IPostService
	{
		IDataResult<Post> GetById(int postId);
		IDataResult<List<Post>> GetList();
		IResult Add(Post post);
		IResult Delete(int postId);
		IResult Update(Post post);
		IResult CheckIfPostTitleExists(string title);
	}
}
