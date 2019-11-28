using System;
using System.Collections.Generic;
using System.Text;
using MyBlog.Core.Utilities.Results.Abstract;
using MyBlog.Entities.Concrete;

namespace MyBlog.Business.Abstract
{
	public interface ITagService
	{
		IDataResult<List<Tag>> GetAll();
		IResult Add(Tag tag);
		IResult Update(Tag tag);
		IResult Delete(int tagId);
		IDataResult<Tag> GetById(int tagId);
	}
}
