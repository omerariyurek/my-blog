using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyBlog.Entities.Concrete;

namespace MyBlog.WebUI.Areas.Administrator.Models.ViewModels
{
	public class ContactIndexViewModel
	{
		public Contact Contact { get; set; }
		public List<Contact> Contacts { get; set; }
		public int PageSize { get; set; }
		public int PageCount { get; set; }
		public int CurrentPage { get; set; }
		public string SearchContact { get; set; }
	}
}
