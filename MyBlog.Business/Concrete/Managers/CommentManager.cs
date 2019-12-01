using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyBlog.Business.Abstract;
using MyBlog.Business.BusinessAspects.Autofac.Security;
using MyBlog.Core.Aspects.Autofac.Caching;
using MyBlog.Core.Utilities.Results.Abstract;
using MyBlog.Core.Utilities.Results.Concrete;
using MyBlog.DataAccess.Abstract;
using MyBlog.Entities.Concrete;

namespace MyBlog.Business.Concrete.Managers
{
	public class CommentManager : ICommentService
	{
		private ICommentDal _commentDal;

		public CommentManager(ICommentDal commentDal)
		{
			_commentDal = commentDal;
		}

		[SecuredOperation("Admin", Priority = 1)]
		[CacheAspect(Priority = 2)]
		public IDataResult<List<Comment>> GetAll()
		{
			return new SuccessDataResult<List<Comment>>(_commentDal.GetAll().ToList());
		}

		[CacheRemoveAspect("ICommentService.Get", Priority = 1)]
		public IResult Add(Comment comment)
		{
			_commentDal.Add(comment);
			return new SuccessResult("");
		}

		[SecuredOperation("Admin", Priority = 1)]
		[CacheRemoveAspect("ICommentService.Get", Priority = 2)]
		public IResult Update(Comment comment)
		{
			_commentDal.Update(comment);
			return new SuccessResult("");
		}

		[SecuredOperation("Admin", Priority = 1)]
		[CacheRemoveAspect("ICommentService.Get", Priority = 2)]
		public IResult Delete(int commentId)
		{
			_commentDal.Delete(new Comment {CommentId = commentId});
			return new SuccessResult("");
		}

		[SecuredOperation("Admin", Priority = 1)]
		public IDataResult<Comment> GetById(int commentId)
		{
			return new SuccessDataResult<Comment>(_commentDal.GetComment(commentId));
		}
	}
}
