using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyBlog.Business.Abstract;
using MyBlog.Business.ValidationRules.FluentValidation;
using MyBlog.Core.Aspects.Autofac.Caching;
using MyBlog.Core.Aspects.Autofac.Validation;
using MyBlog.Core.Utilities.Results.Abstract;
using MyBlog.Core.Utilities.Results.Concrete;
using MyBlog.DataAccess.Abstract;
using MyBlog.Entities.Concrete;

namespace MyBlog.Business.Concrete.Managers
{
	public class TagManager : ITagService
	{
		private ITagDal _tagDal;

		public TagManager(ITagDal tagDal)
		{
			_tagDal = tagDal;
		}

		[CacheAspect()]
		public IDataResult<List<Tag>> GetAll()
		{
			return new SuccessDataResult<List<Tag>>(_tagDal.GetList().ToList());
		}

		[ValidationAspect(typeof(TagValidator),Priority = 1)]
		[CacheRemoveAspect("ITagService.Get",Priority = 2)]
		public IResult Add(Tag tag)
		{
			_tagDal.Add(tag);
			return new SuccessResult();
		}

		[ValidationAspect(typeof(TagValidator), Priority = 1)]
		[CacheRemoveAspect("ITagService.Get", Priority = 2)]
		public IResult Update(Tag tag)
		{
			_tagDal.Update(tag);
			return new SuccessResult();
		}

		[CacheRemoveAspect("ITagService.Get")]
		public IResult Delete(int tagId)
		{
			_tagDal.Delete(new Tag{TagId = tagId});
			return new SuccessResult();
		}

		[CacheAspect()]
		public IDataResult<Tag> GetById(int tagId)
		{
			return new SuccessDataResult<Tag>(_tagDal.Get(x=>x.TagId==tagId));
		}
	}
}
