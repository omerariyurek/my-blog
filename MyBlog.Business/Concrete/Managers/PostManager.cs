using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyBlog.Business.Abstract;
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

		public IDataResult<Post> GetById(int postId)
		{
			return new SuccessDataResult<Post>(_postDal.Get(x => x.PostId == postId));
		}

		public IDataResult<List<Post>> GetList()
		{
			return new SuccessDataResult<List<Post>>(_postDal.GetList().ToList());
		}

		public IResult Add(Post post)
		{
			_postDal.Add(post);
			return new SuccessResult("Post başarıyla kaydedildi.");
		}

		public IResult Delete(Post post)
		{
			_postDal.Delete(post);
			return new SuccessResult("Post başarıyla silindi.");
		}

		public IResult Update(Post post)
		{
			_postDal.Update(post);
			return new SuccessResult("Post başarıyla güncellendi.");
		}
	}
}