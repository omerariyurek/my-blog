using System;
using System.Collections.Generic;
using System.Text;
using MyBlog.Core.DataAccess.Abstract;
using MyBlog.Core.Entities.Concrete;
using MyBlog.Entities.Dtos;

namespace MyBlog.DataAccess.Abstract
{
	public interface IUserDal : IEntityRepository<User>
	{
		List<OperationClaimDto> GetClaims(User user);

	}
}
