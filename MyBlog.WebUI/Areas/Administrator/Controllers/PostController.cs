using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyBlog.WebUI.Areas.Administrator.Controllers
{
	[Area("Administrator")]
	public class PostController : Controller
    {
        public string Index()
        {
	        return "test";
        }
    }
}