using System;
using System.Collections.Generic;
using System.Text;
using MyBlog.Core.Entities.Concrete;
using MyBlog.Core.Utilities.Results.Abstract;
using MyBlog.Entities.Dtos;

namespace MyBlog.Business.Abstract
{
	public interface IUserService
	{
		IDataResult<List<OperationClaim>> OperationClaims(User user);
		IResult Add(User user);
		IDataResult<User> CheckIfUserNameExists(string userName);
	}
}