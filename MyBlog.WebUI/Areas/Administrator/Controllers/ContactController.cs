using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyBlog.Business.Abstract;
using MyBlog.Entities.Concrete;
using MyBlog.WebUI.Areas.Administrator.Models.ViewModels;

namespace MyBlog.WebUI.Areas.Administrator.Controllers
{
	[Area("Administrator")]
	[Authorize]
	public class ContactController : Controller
	{
		private IContactService _contactService;

		public ContactController(IContactService contactService)
		{
			_contactService = contactService;
		}

		[HttpGet("administrator/contacts")]
	    public IActionResult Index(string search)
	    {
		    var contacts = _contactService.GetAll().Data;
		    if (!string.IsNullOrEmpty(search))
		    {
			    contacts = contacts.Where(x => x.ContactName.Contains(search) || x.Message.Contains(search)).ToList();
			    TempData.Add("searchContact", search);
		    }
			var model = new ContactIndexViewModel
			{
				Contact = new Contact(),
				Contacts = contacts
			};
	        return View(model);
        }
	    [HttpPost]
	    public IActionResult Delete(int id)
	    {
		    var deleteOperation = _contactService.Delete(id);
		    return Json(deleteOperation.Message);
	    }

	    [HttpPost]
	    public IActionResult Get(int id)
	    {
		    var comment = _contactService.GetById(id).Data;
		    return Json(comment);
	    }

	    [HttpPost]
	    public IActionResult Update(Contact contact)
	    {
		    _contactService.Update(contact);
		    return RedirectToAction("Index");
	    }
	}
}