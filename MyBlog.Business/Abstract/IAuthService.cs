using System;
using System.Collections.Generic;
using System.Text;
using MyBlog.Core.Entities.Concrete;
using MyBlog.Core.Entities.Dtos;
using MyBlog.Core.Utilities.Results.Abstract;
using MyBlog.Entities.Dtos;

namespace MyBlog.Business.Abstract
{
	public interface IAuthService
	{
		IDataResult<User> Login(UserForLoginDto userForLoginDto);
		IDataResult<List<OperationClaim>> OperationClaims(User user);
	}
}
