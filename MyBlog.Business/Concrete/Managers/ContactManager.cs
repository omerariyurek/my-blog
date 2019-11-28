using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using MyBlog.Business.Abstract;
using MyBlog.Core.Utilities.Results.Abstract;
using MyBlog.Core.Utilities.Results.Concrete;
using MyBlog.DataAccess.Abstract;
using MyBlog.Entities.Concrete;

namespace MyBlog.Business.Concrete.Managers
{
	public class ContactManager : IContactService
	{
		private IContactDal _contactDal;

		public ContactManager(IContactDal contactDal)
		{
			_contactDal = contactDal;
		}

		public IDataResult<List<Contact>> GetAll()
		{
			return new SuccessDataResult<List<Contact>>(_contactDal.GetList().ToList());
		}

		public IResult Add(Contact contact)
		{
			_contactDal.Add(contact);
			return new SuccessResult("");
		}

		public IResult Update(Contact contact)
		{
			_contactDal.Update(contact);
			return new SuccessResult("");
		}

		public IResult Delete(int contactId)
		{
			_contactDal.Delete(new Contact{ContactId = contactId});
			return new SuccessResult("");
		}

		public IDataResult<Contact> GetById(int contactId)
		{
			return new SuccessDataResult<Contact>(_contactDal.Get(x=>x.ContactId==contactId));
		}
	}
}
