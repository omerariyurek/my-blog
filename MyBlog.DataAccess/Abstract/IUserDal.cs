using System;
using System.Collections.Generic;
using System.Text;
using MyBlog.Core.DataAccess.Abstract;
using MyBlog.Core.Entities.Concrete;

namespace MyBlog.DataAccess.Abstract
{
 	public interface IUserDal : IEntityRepository<User>
	{
	}
}
