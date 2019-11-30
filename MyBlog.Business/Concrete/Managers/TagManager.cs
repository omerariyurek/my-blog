using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyBlog.Business.Abstract;
using MyBlog.Business.Constants;
using MyBlog.Business.ValidationRules.FluentValidation;
using MyBlog.Core.Aspects.Autofac.Caching;
using MyBlog.Core.Aspects.Autofac.Validation;
using MyBlog.Core.Extensions;
using MyBlog.Core.Utilities.Business;
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

		[CacheAspect()]
		public IDataResult<List<Tag>> GetListActive()
		{
			return new SuccessDataResult<List<Tag>>(_tagDal.GetList(x=>x.Status==true).ToList());
		}

		[ValidationAspect(typeof(TagValidator), Priority = 1)]
		[CacheRemoveAspect("ITagService.Get", Priority = 2)]
		public IResult Add(Tag tag)
		{
			IResult result = BusinessRules.Run(CheckIfTagNameExists(tag.TagName));
			if (result != null)
			{
				return result;
			}
			tag.Status = true;
			tag.SeoUrl = tag.TagName.CreateSeoFriendlyUrl();
			_tagDal.Add(tag);
			return new SuccessResult(Messages.TagAdded);
		}

		[ValidationAspect(typeof(TagValidator), Priority = 1)]
		[CacheRemoveAspect("ITagService.Get", Priority = 2)]
		public IResult Update(Tag tag)
		{
			var checkToTag = _tagDal.Get(x => x.TagId == tag.TagId);
			if (checkToTag.TagName==tag.TagName)
			{
				tag.SeoUrl = checkToTag.SeoUrl;
				_tagDal.Update(tag);
			}
			else
			{
				IResult result = BusinessRules.Run(CheckIfTagNameExists(tag.TagName));
				if (result != null)
				{
					return result;
				}
				tag.Status = true;
				tag.SeoUrl = tag.TagName.CreateSeoFriendlyUrl();
				_tagDal.Add(tag);
			}
			return new SuccessResult(Messages.TagUpdated);
		}

		[CacheRemoveAspect("ITagService.Get")]
		public IResult Delete(int tagId)
		{
			_tagDal.Delete(new Tag { TagId = tagId });
			return new SuccessResult();
		}

		[CacheAspect()]
		public IDataResult<Tag> GetById(int tagId)
		{
			return new SuccessDataResult<Tag>(_tagDal.Get(x => x.TagId == tagId));
		}

		[CacheAspect()]
		public IResult CheckIfTagNameExists(string tagName)
		{
			var tagToCheck = _tagDal.Get(x => x.TagName == tagName);
			if (tagToCheck != null)
			{
				return new ErrorResult(Messages.TagNameAlreadyExists);
			}
			return new SuccessResult();
		}
	}
}
