using System;
using System.Collections.Generic;
using System.Text;
using MyBlog.Core.Entities.Concrete;
using MyBlog.Entities.Dtos;

namespace MyBlog.Business.Abstract
{
	public interface IUserService
	{
		List<OperationClaimDto> OperationClaims(User user);
		void Add(User user);
		User GetByUsername(string userName);
	}
}
