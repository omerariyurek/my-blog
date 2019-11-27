using System;
using System.Collections.Generic;
using System.Text;
using MyBlog.Business.Abstract;
using MyBlog.Business.Constants;
using MyBlog.Business.ValidationRules.FluentValidation;
using MyBlog.Core.Aspects.Autofac.Validation;
using MyBlog.Core.Entities.Concrete;
using MyBlog.Core.Entities.Dtos;
using MyBlog.Core.Utilities.Business;
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

		[ValidationAspect(typeof(UserForLoginValidator),Priority = 1)]
		public IDataResult<User> Login(UserForLoginDto userForLoginDto)
		{
			var userToCheck = _userService.CheckIfUserNameExists(userForLoginDto.UserName);
			if (!userToCheck.Success)
			{
				return new ErrorDataResult<User>(Messages.UserNotFound);
			}

			if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password, userToCheck.Data.PasswordHash, userToCheck.Data.PasswordSalt))
			{
				return new ErrorDataResult<User>(Messages.PasswordError);
			}
			return new SuccessDataResult<User>(userToCheck.Data, Messages.SuccessfulLogin);
		}

		public IDataResult<List<OperationClaim>> OperationClaims(User user)
		{
			return _userService.OperationClaims(user);
		}

	}
}