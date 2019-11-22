using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using MyBlog.Business.Abstract;
using MyBlog.Core.Entities.Concrete;
using MyBlog.Core.Utilities.Security.Web;

namespace MyBlog.WebUI.Areas.Administrator.Controllers
{
	[Area("Administrator")]
	public class AuthController : Controller
	{
		//private IAuthService _authService;

		//public AuthController(IAuthService authService)
		//{
		//	_authService = authService;
		//}

		public async Task<IActionResult> Login()
		{
			var user = new User
			{
				Id = 1,
				Status = true,
				Email = "aariyurekomer@gmail.com",
				FirstName = "Omer",
				LastName = "Ariyurek",
			};
			var operationClaims = new List<OperationClaim>()
			{
				new OperationClaim(){Id = 1,
					Name = "Admin"}
			};
			var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);
			identity.AddClaims(new AuthenticationHelper().SetClaims(user, operationClaims));
			var principal = new ClaimsPrincipal(identity);
			await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
			return RedirectToAction("Index", "Home");
		}
	}
}