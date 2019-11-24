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

        [Route("error/404")]
        public IActionResult PageNotFound()
        {
	        return View();
        }
    }
}