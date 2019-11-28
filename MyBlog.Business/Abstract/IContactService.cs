using System;
using System.Collections.Generic;
using System.Text;
using MyBlog.Core.Utilities.Results.Abstract;
using MyBlog.Entities.Concrete;

namespace MyBlog.Business.Abstract
{
	public interface IContactService
	{
		IDataResult<List<Contact>> GetAll();
		IResult Add(Contact contact);
		IResult Update(Contact contact);
		IResult Delete(int contactId);
		IDataResult<Contact> GetById(int contactId);
	}
}
