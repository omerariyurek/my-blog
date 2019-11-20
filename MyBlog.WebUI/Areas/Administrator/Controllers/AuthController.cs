using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyBlog.WebUI.Areas.Administrator.Controllers
{
	[Area("Administrator")]
    public class AuthController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}