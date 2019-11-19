using System;
using System.Collections.Generic;
using System.Text;
using MyBlog.Core.DataAccess.Concrete.EntityFramework;
using MyBlog.Core.Entities.Concrete;
using MyBlog.DataAccess.Abstract;
using MyBlog.DataAccess.Concrete.EntityFramework.Contexts;

namespace MyBlog.DataAccess.Concrete.EntityFramework
{
	public class EfUserDal : EfEntityRepositoryBase<User,BlogContext>,IUserDal
	{
	}
}
