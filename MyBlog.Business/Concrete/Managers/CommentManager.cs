using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using MyBlog.Business.Abstract;
using MyBlog.Business.BusinessAspects.Autofac.Security;
using MyBlog.Business.Constants;
using MyBlog.Business.ValidationRules.FluentValidation;
using MyBlog.Core.Aspects.Autofac.Caching;
using MyBlog.Core.Aspects.Autofac.Validation;
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

		[ValidationAspect(typeof(CommentValidator),Priority = 1)]
		[CacheRemoveAspect("ICommentService.Get", Priority = 2)]
		public IResult Add(Comment comment)
		{
			comment.Approved = true;
			_commentDal.Add(comment);
			return new SuccessResult(Messages.CommentAdded);
		}

		[ValidationAspect(typeof(CommentValidator),Priority = 1)]
		[SecuredOperation("Admin", Priority = 2)]
		[CacheRemoveAspect("ICommentService.Get", Priority = 3)]
		public IResult Update(Comment comment)
		{
			_commentDal.Update(comment);
			return new SuccessResult(Messages.CommentUpdated);
		}

		[SecuredOperation("Admin", Priority = 1)]
		[CacheRemoveAspect("ICommentService.Get", Priority = 2)]
		public IResult Delete(int commentId)
		{
			_commentDal.Delete(new Comment {CommentId = commentId});
			return new SuccessResult(Messages.CommentDeleted);
		}

		[SecuredOperation("Admin", Priority = 1)]
		[CacheAspect()]
		public IDataResult<Comment> GetById(int commentId)
		{
			return new SuccessDataResult<Comment>(_commentDal.GetComment(commentId));
		}

		[CacheAspect()]
		public IDataResult<List<Comment>> GetByPostId(int postId)
		{
			return new SuccessDataResult<List<Comment>>(_commentDal.GetList(x=>x.Approved &&x.PostId==postId).ToList());
		}
	}
}
