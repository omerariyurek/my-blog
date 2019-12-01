using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyBlog.Business.Abstract;
using MyBlog.Business.BusinessAspects.Autofac.Security;
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
using MyBlog.Entities.Dtos;

namespace MyBlog.Business.Concrete.Managers
{
	public class TagManager : ITagService
	{
		private ITagDal _tagDal;

		public TagManager(ITagDal tagDal)
		{
			_tagDal = tagDal;
		}

		[SecuredOperation("Admin", Priority = 1)]
		[CacheAspect(Priority = 2)]
		public IDataResult<List<Tag>> GetAll()
		{
			return new SuccessDataResult<List<Tag>>(_tagDal.GetList().ToList());
		}

		[CacheAspect()]
		public IDataResult<List<Tag>> GetListActive()
		{
			return new SuccessDataResult<List<Tag>>(_tagDal.GetList(x => x.Status == true).ToList());
		}

		[SecuredOperation("Admin", Priority = 1)]
		[ValidationAspect(typeof(TagValidator), Priority = 2)]
		[CacheRemoveAspect("ITagService.Get", Priority = 3)]
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

		[SecuredOperation("Admin", Priority = 1)]
		[ValidationAspect(typeof(TagValidator), Priority = 2)]
		[CacheRemoveAspect("ITagService.Get", Priority = 3)]
		public IResult Update(Tag tag)
		{
			var checkToTag = _tagDal.Get(x => x.TagId == tag.TagId);
			if (checkToTag.TagName == tag.TagName)
			{
				tag.SeoUrl = checkToTag.SeoUrl;
				_tagDal.Update(tag);
				return new SuccessResult(Messages.TagUpdated);

			}
			IResult result = BusinessRules.Run(CheckIfTagNameExists(tag.TagName));
			if (result != null)
			{
				return result;
			}
			tag.Status = true;
			tag.SeoUrl = tag.TagName.CreateSeoFriendlyUrl();
			_tagDal.Add(tag);
			return new SuccessResult(Messages.TagUpdated);
		}

		[SecuredOperation("Admin", Priority = 1)]
		[CacheRemoveAspect("ITagService.Get",Priority = 2)]
		public IResult Delete(int tagId)
		{
			_tagDal.Delete(new Tag { TagId = tagId });
			return new SuccessResult();
		}

		[SecuredOperation("Admin", Priority = 1)]
		[CacheAspect(Priority = 2)]
		public IDataResult<Tag> GetById(int tagId)
		{
			return new SuccessDataResult<Tag>(_tagDal.Get(x => x.TagId == tagId));
		}

		[SecuredOperation("Admin", Priority = 1)]
		public IResult CheckIfTagNameExists(string tagName)
		{
			var tagToCheck = _tagDal.Get(x => x.TagName == tagName);
			if (tagToCheck != null)
			{
				return new ErrorResult(Messages.TagNameAlreadyExists);
			}
			return new SuccessResult();
		}

		[SecuredOperation("Admin", Priority = 1)]
		[CacheAspect(Priority = 2)]
		public IDataResult<List<TagsDto>> GetSelectedTags()
		{
			return new SuccessDataResult<List<TagsDto>>(_tagDal.GetsTags().ToList());
		}

		public IDataResult<List<CategoriesDto>> GetSelectedCategories()
		{
			throw new NotImplementedException();
		}
	}
}
