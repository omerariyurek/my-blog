﻿using System;
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
using MyBlog.Entities.Dtos;

namespace MyBlog.WebUI.Areas.Administrator.Controllers
{
	[Area("Administrator")]
	public class AuthController : Controller
	{
		private IAuthService _authService;

		public AuthController(IAuthService authService)
		{
			_authService = authService;
		}

		[HttpGet]
		public IActionResult Login()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Login(UserForLoginDto userForLoginDto,string returnUrl)
		{
			var userToLogin = _authService.Login(userForLoginDto);
			if (!userToLogin.Success)
			{
				ModelState.AddModelError("LoginError",userToLogin.Message);
			}
			else
			{
				var userOperationClaims = _authService.OperationClaims(userToLogin.Data);
				var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);
				identity.AddClaims(new AuthenticationHelper().SetClaims(userToLogin.Data,userOperationClaims.Data));
				var principal = new ClaimsPrincipal(identity);
				await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
				return RedirectToAction("Index", "Home");
			}
			return View();
		}
	}
}