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
					Status = x.Status,
					CoverImage = x.CoverImage,
					FirstImage = x.FirstImage
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

		public List<PostDetailDto> GetPostDetails()
		{
			using (var context = new BlogContext())
			{
				var result = context.Posts.ToList().Select(x => new PostDetailDto
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
					CoverImage = x.CoverImage,
					FirstImage = x.FirstImage,
					PostCategories = GetPostCategories(x.PostId)
				}).ToList();
				return result;
			}
		}

		public List<PostDetailDto> GetCategoryPosts(int categoryId)
		{
			using (var context = new BlogContext())
			{
				var postDetailDto = new List<PostDetailDto>();
				var result = from post in context.Posts
							 join postCategories in context.PostCategories
								 on post.PostId equals postCategories.PostId
							 where postCategories.CategoryId == categoryId
							 select new
							 {
								 PostId = post.PostId,
								 CommentStatus = post.CommentStatus,
								 SeoUrl = post.SeoUrl,
								 Title = post.Title,
								 Content = post.Content,
								 CreatedDate = post.CreatedDate,
								 IsHome = post.IsHome,
								 MetaDescription = post.MetaDescription,
								 MetaKeywords = post.MetaKeywords,
								 ModifiedDate = post.ModifiedDate,
								 Status = post.Status,
								 FirstImage = post.FirstImage,
								 CoverImage = post.CoverImage
							 };
				foreach (var item in result)
				{
					postDetailDto.Add(new PostDetailDto
					{
						PostId = item.PostId,
						CommentStatus = item.CommentStatus,
						SeoUrl = item.SeoUrl,
						Title = item.Title,
						Content = item.Content,
						CreatedDate = item.CreatedDate,
						IsHome = item.IsHome,
						MetaDescription = item.MetaDescription,
						MetaKeywords = item.MetaKeywords,
						ModifiedDate = item.ModifiedDate,
						Status = item.Status,
						CoverImage = item.CoverImage,
						FirstImage = item.FirstImage,
						PostCategories = GetPostCategories(item.PostId)
					});
				}
				return postDetailDto;
			}
		}

		public List<PostDetailDto> GetTagPosts(int tagId)
		{
			using (var context = new BlogContext())
			{
				var postDetailDto = new List<PostDetailDto>();
				var result = from post in context.Posts
							 join posTags in context.PostTags
								 on post.PostId equals posTags.PostId
							 where posTags.TagId == tagId
							 select new
							 {
								 PostId = post.PostId,
								 CommentStatus = post.CommentStatus,
								 SeoUrl = post.SeoUrl,
								 Title = post.Title,
								 Content = post.Content,
								 CreatedDate = post.CreatedDate,
								 IsHome = post.IsHome,
								 MetaDescription = post.MetaDescription,
								 MetaKeywords = post.MetaKeywords,
								 ModifiedDate = post.ModifiedDate,
								 Status = post.Status,
								 FirstImage = post.FirstImage,
								 CoverImage = post.CoverImage,
							 };
				foreach (var item in result)
				{
					postDetailDto.Add(new PostDetailDto
					{
						PostId = item.PostId,
						CommentStatus = item.CommentStatus,
						SeoUrl = item.SeoUrl,
						Title = item.Title,
						Content = item.Content,
						CreatedDate = item.CreatedDate,
						IsHome = item.IsHome,
						MetaDescription = item.MetaDescription,
						MetaKeywords = item.MetaKeywords,
						ModifiedDate = item.ModifiedDate,
						Status = item.Status,
						CoverImage = item.CoverImage,
						FirstImage = item.FirstImage,
						PostCategories = GetPostCategories(item.PostId)
					});
				}
				return postDetailDto;
			}
		}

		public PostDetailDto GetPostDetail(int postId)
		{
			using (var context = new BlogContext())
			{

				var result = context.Posts.FirstOrDefault(x => x.PostId == postId);
				if (result == null) return null;
				var postDetail = new PostDetailDto
				{
					PostId = result.PostId,
					SeoUrl = result.SeoUrl,
					CommentStatus = result.CommentStatus,
					Content = result.Content,
					CoverImage = result.CoverImage,
					CreatedDate = result.CreatedDate,
					FirstImage = result.FirstImage,
					IsHome = result.IsHome,
					MetaDescription = result.MetaDescription,
					MetaKeywords = result.MetaKeywords,
					ModifiedDate = result.ModifiedDate,
					Status = result.Status,
					Title = result.Title,
					PostCategories = GetPostCategories(result.PostId)
				};
				return postDetail;

			}
		}
	}
}
