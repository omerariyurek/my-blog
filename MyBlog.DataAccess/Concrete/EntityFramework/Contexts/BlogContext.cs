using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using MyBlog.Core.Entities.Concrete;
using MyBlog.Entities.Concrete;

namespace MyBlog.DataAccess.Concrete.EntityFramework.Contexts
{
	public class BlogContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=Blog; Integrated Security=true");
			
		}

		public DbSet<Post> Posts { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Comment> Comments { get; set; }
		public DbSet<Tag> Tags { get; set; }
		public DbSet<PostTag> PostTags { get; set; }
		public DbSet<PostCategory> PostCategories { get; set; }
		public DbSet<User> Users { get; set; }
		public DbSet<OperationClaim> OperationClaims { get; set; }
		public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
		public DbSet<Log> Logs { get; set; }
		public DbSet<Contact> Contacts { get; set; }

	}
}
