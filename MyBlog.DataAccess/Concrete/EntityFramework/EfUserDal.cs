using System;
using System.Collections.Generic;
using System.Text;
using MyBlog.Core.DataAccess.Concrete.EntityFramework;
using MyBlog.Core.Entities.Concrete;
using MyBlog.DataAccess.Abstract;
using MyBlog.DataAccess.Concrete.EntityFramework.Contexts;
using MyBlog.Entities.Dtos;
using System.Linq;

namespace MyBlog.DataAccess.Concrete.EntityFramework
{
	public class EfUserDal : EfEntityRepositoryBase<User,BlogContext>,IUserDal
	{
		public List<OperationClaim> GetClaims(User user)
		{
			using (var context = new BlogContext())
			{
				var result = from operationClaim in context.OperationClaims
					join userOperationClaim in context.UserOperationClaims
						on operationClaim.Id equals userOperationClaim.OperationClaimId
					where userOperationClaim.UserId == user.Id
					select new OperationClaim
					{
						Id = operationClaim.Id,
						Name = operationClaim.Name
					};
				return result.ToList();
			}
		}
	}
}