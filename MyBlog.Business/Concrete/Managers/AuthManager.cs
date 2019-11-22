using System;
using System.Collections.Generic;
using System.Text;
using MyBlog.Business.Abstract;
using MyBlog.Business.Constants;
using MyBlog.Core.Entities.Concrete;
using MyBlog.Core.Utilities.Hashing;
using MyBlog.Core.Utilities.Results.Abstract;
using MyBlog.Core.Utilities.Results.Concrete;
using MyBlog.Entities.Dtos;

namespace MyBlog.Business.Concrete.Managers
{
	public class AuthManager : IAuthService
	{
		private IUserService _userService;

		public AuthManager(IUserService userService)
		{
			_userService = userService;
		}

		public IDataResult<User> Login(UserForLoginDto userForLoginDto)
		{
			var userToCheck = _userService.GetByUsername(userForLoginDto.UserName);
			if (userToCheck==null)
			{
				return new ErrorDataResult<User>(Messages.UserNotFound);
			}

			if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password, userToCheck.PasswordHash, userToCheck.PasswordSalt))
			{
				return new ErrorDataResult<User>(Messages.PasswordError);
			}

			return new SuccessDataResult<User>(userToCheck, Messages.SuccessfulLogin);
		}

		public IResult UserExists(string userName)
		{
			if (_userService.GetByUsername(userName) != null)
			{
				return new ErrorResult(Messages.UserAlreadyExists);
			}
			return new SuccessResult();
		}
	}
}