using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyBlog.Business.Abstract;
using MyBlog.Business.BusinessAspects.Autofac.Security;
using MyBlog.Business.Constants;
using MyBlog.Business.ValidationRules.FluentValidation;
using MyBlog.Core.Aspects.Autofac.Caching;
using MyBlog.Core.Aspects.Autofac.Logging;
using MyBlog.Core.Aspects.Autofac.Validation;
using MyBlog.Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;
using MyBlog.Core.Utilities.Results.Abstract;
using MyBlog.Core.Utilities.Results.Concrete;
using MyBlog.DataAccess.Abstract;
using MyBlog.Entities.Concrete;

namespace MyBlog.Business.Concrete.Managers
{
	public class PostManager : IPostService
	{
		private IPostDal _postDal;
		public PostManager(IPostDal postDal)
		{
			_postDal = postDal;
		}

		[CacheAspect]
		public IDataResult<Post> GetById(int postId)
		{
			return new SuccessDataResult<Post>(_postDal.Get(x => x.PostId == postId));
		}

		[CacheAspect(Priority = 3)]
		[SecuredOperation("Admin",Priority = 1)]
		[LogAspect(typeof(DatabaseLogger),Priority = 2)]
		public IDataResult<List<Post>> GetList()
		{
			return new SuccessDataResult<List<Post>>(_postDal.GetList().ToList());
		}

		[ValidationAspect(typeof(PostValidator), Priority = 1)]
		[CacheRemoveAspect("IPostService.Get")]
		public IResult Add(Post post)
		{
			_postDal.Add(post);
			return new SuccessResult(Messages.PostAdded);
		}

		[CacheRemoveAspect("IPostService.Get")]
		public IResult Delete(Post post)
		{
			_postDal.Delete(post);
			return new SuccessResult(Messages.PostDeleted);
		}


		[ValidationAspect(typeof(PostValidator), Priority = 1)]
		[CacheRemoveAspect("IPostService.Get")]
		public IResult Update(Post post)
		{
			_postDal.Update(post);
			return new SuccessResult(Messages.PostUpdated);
		}
	}
}