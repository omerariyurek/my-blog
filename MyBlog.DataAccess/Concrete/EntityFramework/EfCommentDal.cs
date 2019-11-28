using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using MyBlog.Core.DataAccess.Concrete.EntityFramework;
using MyBlog.DataAccess.Abstract;
using MyBlog.DataAccess.Concrete.EntityFramework.Contexts;
using MyBlog.DataAccess.Migrations;
using MyBlog.Entities.Concrete;

namespace MyBlog.DataAccess.Concrete.EntityFramework
{
	public class EfCommentDal : EfEntityRepositoryBase<Comment,BlogContext>,ICommentDal
	{
		public List<Comment> GetAll()
		{
			using (var context = new BlogContext())
			{
				return context.Comments.Include(x => x.Post).ToList();
			}
		}

		public Comment GetComment(int commentId)
		{
			using (var context = new BlogContext())
			{
				return context.Comments.Include(x => x.Post).FirstOrDefault(x => x.CommentId == commentId);
			}
		}
	}
}
