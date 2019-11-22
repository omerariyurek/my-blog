using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using MyBlog.Core.Extensions;
using System.Linq;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using MyBlog.Core.Entities.Concrete;

namespace MyBlog.Core.Utilities.Security.Web
{
	public class AuthenticationHelper
	{
		public IEnumerable<Claim> SetClaims(User user, List<OperationClaim> operationClaims)
		{
			var claims = new List<Claim>();
			claims.AddIdentifier(user.Id.ToString());
			claims.AddName($"{user.FirstName} {user.LastName}");
			claims.AddRoles(operationClaims.Select(c => c.Name).ToArray());
			return claims;
		}
	}
}
