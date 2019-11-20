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
		IDataResult<List<Post>> GetAll();
		IDataResult<List<Post>> GetListByCategory(int categoryId);
		IResult Add(Post post);
		IResult Delete(Post post);
		IResult Update(Post post);
	}
}
