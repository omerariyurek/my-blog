using System;
using System.Collections.Generic;
using System.Text;
using MyBlog.Core.Utilities.Results.Abstract;
using MyBlog.Entities.Concrete;

namespace MyBlog.Business.Abstract
{
	public interface ICommentService
	{
		IDataResult<List<Comment>> GetAll();
		IResult Add(Comment comment);
		IResult Update(Comment comment);
		IResult Delete(int commentId);
		IDataResult<Comment> GetById(int commentId);
	}
}
