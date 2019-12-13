using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using MyBlog.Business.Abstract;
using MyBlog.Business.BusinessAspects.Autofac.Security;
using MyBlog.Business.Constants;
using MyBlog.Business.ValidationRules.FluentValidation;
using MyBlog.Core.Aspects.Autofac.Caching;
using MyBlog.Core.Aspects.Autofac.Validation;
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

		[SecuredOperation("Admin", Priority = 1)]
		[CacheAspect(Priority = 2)]
		public IDataResult<List<Contact>> GetAll()
		{
			return new SuccessDataResult<List<Contact>>(_contactDal.GetList().ToList());
		}

		[ValidationAspect(typeof(ContactValidator),Priority = 1)]
		[CacheRemoveAspect("IContactService.Get", Priority = 2)]
		public IResult Add(Contact contact)
		{
			_contactDal.Add(contact);
			return new SuccessResult(Messages.ContactAdded);
		}

		[SecuredOperation("Admin", Priority = 1)]
		[CacheRemoveAspect("IContactService.Get", Priority = 2)]
		public IResult Update(Contact contact)
		{
			_contactDal.Update(contact);
			return new SuccessResult(Messages.ContactUpdated);
		}

		[SecuredOperation("Admin", Priority = 1)]
		[CacheRemoveAspect("IContactService.Get", Priority = 2)]
		public IResult Delete(int contactId)
		{
			_contactDal.Delete(new Contact{ContactId = contactId});
			return new SuccessResult(Messages.ContactDeleted);
		}

		[SecuredOperation("Admin", Priority = 1)]
		[CacheAspect(Priority = 2)]
		public IDataResult<Contact> GetById(int contactId)
		{
			return new SuccessDataResult<Contact>(_contactDal.Get(x=>x.ContactId==contactId));
		}
	}
}
