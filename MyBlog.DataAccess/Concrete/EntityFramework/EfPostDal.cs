using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
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

		public List<PostTagsDto> GetPostTags(int postId)
		{
			using (var context = new BlogContext())
			{
				var result = from tag in context.Tags
							 join postTags in context.PostTags
								 on tag.TagId equals postTags.TagId
							 where postTags.PostId == postId
							 select new PostTagsDto
							 {
								 PostId = postTags.PostId,
								 TagName = tag.TagName,
								 SeoUrl = tag.SeoUrl,
								 TagId = tag.TagId
							 };
				return result.ToList();
			}
		}

		public List<PostCategoriesDto> GetPostCategories(int postId)
		{
			using (var context = new BlogContext())
			{
				var result = from category in context.Categories
							 join postCategories in context.PostCategories
								 on category.CategoryId equals postCategories.CategoryId
							 where postCategories.PostId == postId
							 select new PostCategoriesDto
							 {
								 PostId = postCategories.PostId,
								 CategoryName = category.CategoryName,
								 SeoUrl = category.SeoUrl,
								 CategoryId = category.CategoryId
							 };
				return result.ToList();
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

		public List<PostsDto> GetPostsDto()
		{
			using (var context = new BlogContext())
			{
				var result = context.Posts.ToList().Select(x => new PostsDto
				{
					PostId = x.PostId,
					SeoUrl = x.SeoUrl,
					Title = x.Title,
					Content = x.Content,
					CommentStatus = x.CommentStatus,
					CreatedDate = x.CreatedDate,
					IsHome = x.IsHome,
					MetaDescription = x.MetaDescription,
					MetaKeywords = x.MetaKeywords,
					ModifiedDate = x.ModifiedDate,
					Status = x.Status,
					PostTags = GetPostTags(x.PostId),
					PostCategories = GetPostCategories(x.PostId)
				}).ToList();
				return result;
			}
		}
	}
}
