using System;
using System.Collections.Generic;
using System.Text;
using MyBlog.Core.Utilities.Results.Abstract;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos;

namespace MyBlog.Business.Abstract
{
	public interface ITagService
	{
		IDataResult<List<Tag>> GetAll();
		IDataResult<List<Tag>> GetListActive();
		IResult Add(Tag tag);
		IResult Update(Tag tag);
		IResult Delete(int tagId);
		IDataResult<Tag> GetById(int tagId);
		IResult CheckIfTagNameExists(string tagName);
		IDataResult<List<TagsDto>> GetSelectedTags();
		IDataResult<Tag> GetByUrl(string seoUrl);
	}
}