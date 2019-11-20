using System;
using System.Collections.Generic;
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
			try
			{
				var post = _postDal.Get(x => x.PostId == postId);
				return new SuccessDataResult<Post>(post);
			}
			catch
			{
				return new ErrorDataResult<Post>("Post getirilemedi!");
			}
			
		}

		public IDataResult<List<Post>> GetAll()
		{
			throw new NotImplementedException();
		}

		public IDataResult<List<Post>> GetListByCategory(int categoryId)
		{
			throw new NotImplementedException();
		}

		public IResult Add(Post post)
		{
			throw new NotImplementedException();
		}

		public IResult Delete(Post post)
		{
			throw new NotImplementedException();
		}

		public IResult Update(Post post)
		{
			throw new NotImplementedException();
		}
	}
}
