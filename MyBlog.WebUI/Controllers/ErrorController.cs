using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyBlog.WebUI.Controllers
{
    public class ErrorController : Controller
    {
		[Route("/error")]
        public IActionResult InternalServerError()
        {
            return View();
        }

        [Route("/404-not-found")]
        public IActionResult PageNotFound()
        {
	        return View();
        }
    }
}