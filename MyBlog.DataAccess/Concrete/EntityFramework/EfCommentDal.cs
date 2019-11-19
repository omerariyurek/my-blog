using System;
using System.Collections.Generic;
using System.Text;
using MyBlog.Core.DataAccess.Concrete.EntityFramework;
using MyBlog.DataAccess.Abstract;
using MyBlog.DataAccess.Concrete.EntityFramework.Contexts;
using MyBlog.Entities.Concrete;

namespace MyBlog.DataAccess.Concrete.EntityFramework
{
	public class EfCommentDal : EfEntityRepositoryBase<Comment,BlogContext>,ICommentDal
	{
	}
}
