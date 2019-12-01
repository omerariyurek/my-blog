using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyBlog.Core.DataAccess.Concrete.EntityFramework;
using MyBlog.DataAccess.Abstract;
using MyBlog.DataAccess.Concrete.EntityFramework.Contexts;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos;

namespace MyBlog.DataAccess.Concrete.EntityFramework
{
	public class EfPostDal : EfEntityRepositoryBase<Post, BlogContext>, IPostDal
	{
		public void AddPostTags(int postId, int[] tagIds)
		{
			using (var context = new BlogContext())
			{
				var postTags = new List<PostTag>();
				foreach (var tagId in tagIds)
				{
					postTags.Add(new PostTag { PostId = postId, TagId = tagId });
				}
				context.PostTags.AddRange(postTags);
				context.SaveChanges();
			}
		}

		public void AddPostCategories(int postId, int[] categoryIds)
		{
			using (var context = new BlogContext())
			{
				var postCategories = new List<PostCategory>();
				foreach (var categoryId in categoryIds)
				{
					postCategories.Add(new PostCategory { PostId = postId, CategoryId = categoryId });
				}
				context.PostCategories.AddRange(postCategories);
				context.SaveChanges();
			}
		}

		public List<PostTag> GetPostTags(int postId)
		{
			using (var context = new BlogContext())
			{
				return context.PostTags.Where(x => x.PostId == postId).ToList();
			}
		}

		public List<PostCategory> GetPostCategories(int postId)
		{
			using (var context = new BlogContext())
			{
				return context.PostCategories.Where(x => x.PostId == postId).ToList();
			}
		}

		public PostDto GetPostDto(int postId)
		{
			using (var context = new BlogContext())
			{
				var result = context.Posts.Where(x => x.PostId == postId).Select(x => new PostDto
				{
					PostId = x.PostId,
					SeoUrl = x.SeoUrl,
					Title = x.Title,
					CommentStatus = x.CommentStatus,
					Content = x.Content,
					IsHome = x.IsHome,
					CreatedDate = x.CreatedDate,
					MetaDescription = x.MetaDescription,
					MetaKeywords = x.MetaKeywords,
					ModifiedDate = x.ModifiedDate,
					Status = x.Status
				}).FirstOrDefault();
				return result;
			}
		}

		public void DeletePostTags(int postId)
		{
			using (var context = new BlogContext())
			{
				var postTags = context.PostTags.Where(x => x.PostId == postId).ToList();
				context.PostTags.RemoveRange(postTags);
				context.SaveChanges();
			}
		}

		public void DeletePostCategories(int postId)
		{
			using (var context = new BlogContext())
			{
				var postCategories = context.PostCategories.Where(x => x.PostId == postId).ToList();
				context.PostCategories.RemoveRange(postCategories);
				context.SaveChanges();
			}
		}
	}
}
