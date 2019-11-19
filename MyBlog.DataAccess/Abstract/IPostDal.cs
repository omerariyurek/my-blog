using System;
using System.Collections.Generic;
using System.Text;
using MyBlog.Core.DataAccess.Abstract;
using MyBlog.Entities.Concrete;

namespace MyBlog.DataAccess.Abstract
{
	public interface IPostDal : IEntityRepository<Post>
	{
	}
}
