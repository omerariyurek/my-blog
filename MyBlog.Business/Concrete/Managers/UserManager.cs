using System;
using System.Collections.Generic;
using System.Text;
using MyBlog.Business.Abstract;
using MyBlog.Core.Entities.Concrete;
using MyBlog.DataAccess.Abstract;
using MyBlog.Entities.Dtos;

namespace MyBlog.Business.Concrete.Managers
{
	public class UserManager : IUserService
	{
		private IUserDal _userDal;

		public UserManager(IUserDal userDal)
		{
			_userDal = userDal;
		}

		public List<OperationClaimDto> OperationClaims(User user)
		{
			throw new NotImplementedException();
		}

		public void Add(User user)
		{
			throw new NotImplementedException();
		}

		public User GetByUsername(string username)
		{
			throw new NotImplementedException();
		}
	}
}
