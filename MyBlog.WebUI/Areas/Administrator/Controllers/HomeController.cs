using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MyBlog.WebUI.Areas.Administrator.Controllers
{
	[Area("Administrator")]
	public class HomeController : Controller
    {
	    [Authorize]
	    public string Index()
		{
			var name = User.Claims.Where(c => c.Type == ClaimTypes.Name)
				.Select(c => c.Value).SingleOrDefault();
			return "geldin";
        }
    }
}