using System;
using System.Collections.Generic;
using System.Text;
using MyBlog.Core.DataAccess.Abstract;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos;

namespace MyBlog.DataAccess.Abstract
{
	public interface IPostDal : IEntityRepository<Post>
	{
		void AddPostTags(int postId, int[] tagIds);
		void AddPostCategories(int postId, int[] categoryIds);
		List<PostTagsDto> GetPostTags(int postId);
		List<PostCategoriesDto> GetPostCategories(int postId);
		PostDto GetPostDto(int postId);
		void DeletePostTags(int postId);
		void DeletePostCategories(int postId);
		List<PostDetailDto> GetPostDetails();
		List<PostDetailDto> GetCategoryPosts(int categoryId);
		List<PostDetailDto> GetTagPosts(int tagId);
		PostDetailDto GetPostDetail(int postId);

	}
}
