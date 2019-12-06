using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyBlog.Business.Abstract;
using MyBlog.Entities.Concrete;

namespace MyBlog.WebUI.Controllers
{
    public class ContactController : Controller
    {
	    private IContactService _contactService;

	    public ContactController(IContactService contactService)
	    {
		    _contactService = contactService;
	    }

	    [HttpGet("/contact")]
        public IActionResult Index()
        {
            return View(new Contact());
        }

        [HttpPost]
		[ValidateAntiForgeryToken]
        public IActionResult Index(Contact contact)
        {
	        var contactAddOperation = _contactService.Add(contact);
	        TempData.Add(!contactAddOperation.Success ? "Error" : "Success", contactAddOperation.Message);
	        return RedirectToAction("Index");
        }
	}
}