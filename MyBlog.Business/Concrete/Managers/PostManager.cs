using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyBlog.Business.Abstract;
using MyBlog.Business.BusinessAspects.Autofac.Security;
using MyBlog.Business.Constants;
using MyBlog.Business.ValidationRules.FluentValidation;
using MyBlog.Core.Aspects.Autofac.Caching;
using MyBlog.Core.Aspects.Autofac.Logging;
using MyBlog.Core.Aspects.Autofac.Transaction;
using MyBlog.Core.Aspects.Autofac.Validation;
using MyBlog.Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;
using MyBlog.Core.Extensions;
using MyBlog.Core.Utilities.Business;
using MyBlog.Core.Utilities.Results.Abstract;
using MyBlog.Core.Utilities.Results.Concrete;
using MyBlog.DataAccess.Abstract;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos;

namespace MyBlog.Business.Concrete.Managers
{
	public class PostManager : IPostService
	{
		private IPostDal _postDal;
		public PostManager(IPostDal postDal)
		{
			_postDal = postDal;
		}

		[CacheAspect(Priority = 1)]
		public IDataResult<Post> GetById(int postId)
		{
			return new SuccessDataResult<Post>(_postDal.Get(x => x.PostId == postId));
		}

		[CacheAspect(Priority = 1)]
		public IDataResult<PostDto> GetPostDto(int postId)
		{
			return new SuccessDataResult<PostDto>(_postDal.GetPostDto(postId));
		}

		[CacheAspect()]
		public IDataResult<List<PostDetailDto>> GetPostDetails()
		{
			return new SuccessDataResult<List<PostDetailDto>>(_postDal.GetPostDetails());
		}

		[CacheAspect()]
		public IDataResult<List<PostDetailDto>> GetCategoryPosts(int categoryId)
		{
			return new SuccessDataResult<List<PostDetailDto>>(_postDal.GetCategoryPosts(categoryId));
		}

		[SecuredOperation("Admin", Priority = 1)]
		[CacheAspect(Priority = 2)]
		public IDataResult<List<Post>> GetList()
		{
			return new SuccessDataResult<List<Post>>(_postDal.GetList().ToList());
		}

		[SecuredOperation("Admin", Priority = 1)]
		[ValidationAspect(typeof(PostDtoValidator), Priority = 2)]
		[TransactionScopeAspect(Priority = 3)]
		[CacheRemoveAspect("IPostService.Get", Priority = 4)]
		public IResult Add(PostDto postDto)
		{
			IResult result = BusinessRules.Run(CheckIfPostTitleExists(postDto.Title));
			if (result != null)
			{
				return result;
			}
			var post = new Post
			{
				Title = postDto.Title,
				SeoUrl = postDto.Title.CreateSeoFriendlyUrl(),
				CommentStatus = postDto.CommentStatus,
				Content = postDto.Content,
				CreatedDate = DateTime.Now,
				IsHome = postDto.IsHome,
				MetaDescription = postDto.MetaDescription,
				MetaKeywords = postDto.MetaKeywords,
				Status = postDto.CommentStatus,
				CoverImage = postDto.CoverImage,
				FirstImage = postDto.FirstImage
			};
			_postDal.Add(post);
			if (postDto.Categories.Length > 0)
			{
				_postDal.AddPostCategories(post.PostId, postDto.Categories);
			}
			if (postDto.Tags.Length > 0)
			{
				_postDal.AddPostTags(post.PostId, postDto.Tags);
			}
			return new SuccessResult(Messages.PostAdded);
		}

		[SecuredOperation("Admin", Priority = 1)]
		[CacheRemoveAspect("IPostService.Get", Priority = 2)]
		public IResult Delete(int postId)
		{
			_postDal.Delete(new Post { PostId = postId });
			return new SuccessResult(Messages.PostDeleted);
		}

		[SecuredOperation("Admin", Priority = 1)]
		[ValidationAspect(typeof(PostDtoValidator), Priority = 2)]
		[TransactionScopeAspect(Priority = 3)]
		[CacheRemoveAspect("IPostService.Get", Priority = 4)]
		public IResult Update(PostDto postDto)
		{
			var checkToPost = _postDal.Get(x => x.PostId == postDto.PostId);
			if (checkToPost.Title == postDto.Title)
			{
				checkToPost.PostId = postDto.PostId;
				checkToPost.CommentStatus = postDto.CommentStatus;
				checkToPost.Content = postDto.Content;
				checkToPost.IsHome = postDto.IsHome;
				checkToPost.MetaDescription = postDto.MetaDescription;
				checkToPost.MetaKeywords = postDto.MetaKeywords;
				checkToPost.ModifiedDate = DateTime.Now;
				checkToPost.Status = postDto.Status;
				checkToPost.SeoUrl = postDto.Title.CreateSeoFriendlyUrl();
				checkToPost.Title = postDto.Title;
				checkToPost.FirstImage = postDto.FirstImage;
				checkToPost.CoverImage = postDto.CoverImage;
				_postDal.Update(checkToPost);
				if (postDto.Categories.Length > 0)
				{
					_postDal.DeletePostCategories(postDto.PostId);
					_postDal.AddPostCategories(postDto.PostId, postDto.Categories);
				}
				if (postDto.Tags.Length > 0)
				{
					_postDal.DeletePostTags(postDto.PostId);
					_postDal.AddPostTags(postDto.PostId, postDto.Tags);
				}
				return new SuccessResult(Messages.PostUpdated);
			}
			IResult result = BusinessRules.Run(CheckIfPostTitleExists(postDto.Title));
			if (result != null)
			{
				return result;
			}
			checkToPost.PostId = postDto.PostId;
			checkToPost.CommentStatus = postDto.CommentStatus;
			checkToPost.Content = postDto.Content;
			checkToPost.IsHome = postDto.IsHome;
			checkToPost.MetaDescription = postDto.MetaDescription;
			checkToPost.MetaKeywords = postDto.MetaKeywords;
			checkToPost.ModifiedDate = DateTime.Now;
			checkToPost.Status = postDto.Status;
			checkToPost.SeoUrl = postDto.Title.CreateSeoFriendlyUrl();
			checkToPost.Title = postDto.Title;
			checkToPost.FirstImage = postDto.FirstImage;
			checkToPost.CoverImage = postDto.CoverImage;
			_postDal.Update(checkToPost);
			if (postDto.Categories.Length > 0)
			{
				_postDal.DeletePostCategories(postDto.PostId);
				_postDal.AddPostCategories(postDto.PostId, postDto.Categories);
			}
			if (postDto.Tags.Length > 0)
			{
				_postDal.DeletePostTags(postDto.PostId);
				_postDal.AddPostTags(postDto.PostId, postDto.Tags);
			}
			return new SuccessResult(Messages.PostUpdated);
		}


		[SecuredOperation("Admin", Priority = 1)]
		public IResult CheckIfPostTitleExists(string title)
		{
			var postToCheck = _postDal.Get(x => x.Title == title);
			if (postToCheck != null)
			{
				return new ErrorResult(Messages.PostTitleAlreadyExists);
			}
			return new SuccessResult();
		}

		[CacheAspect(Priority = 1)]
		public IDataResult<List<PostTagsDto>> GetPostTags(int postId)
		{
			return new SuccessDataResult<List<PostTagsDto>>(_postDal.GetPostTags(postId));
		}

		[CacheAspect(Priority = 1)]
		public IDataResult<List<PostCategoriesDto>> GetPostCategories(int postId)
		{
			return new SuccessDataResult<List<PostCategoriesDto>>(_postDal.GetPostCategories(postId));
		}

		[CacheAspect()]
		public IDataResult<List<PostDetailDto>> GetTagPosts(int tagId)
		{
			return new SuccessDataResult<List<PostDetailDto>>(_postDal.GetTagPosts(tagId));
		}

		[CacheAspect()]
		public IDataResult<Post> GetByUrl(string seoUrl)
		{
			return new SuccessDataResult<Post>(_postDal.Get(x => x.SeoUrl == seoUrl));
		}

		[CacheAspect()]
		public IDataResult<PostDetailDto> GetPostDetail(int postId)
		{
			return new SuccessDataResult<PostDetailDto>(_postDal.GetPostDetail(postId));
		}

		[CacheAspect()]
		public IDataResult<List<Post>> GetActiveSixPosts()
		{
			return new SuccessDataResult<List<Post>>(_postDal.GetActiveSixPosts());
		}

		[CacheAspect()]
		public IDataResult<List<Post>> GetRandomTwoPosts()
		{
			return new SuccessDataResult<List<Post>>(_postDal.GetRandomTwoPosts());
		}


		[CacheAspect()]
		public IDataResult<List<PostDetailDto>> GetPostsBySearchKey(string postName)
		{
			var posts = GetPostDetails().Data;
			var postDetailDto = posts.Where(x => x.Title.ToLower().Contains(postName.ToLower()) || x.Content.ToLower().Contains(postName.ToLower())).ToList();
			return new SuccessDataResult<List<PostDetailDto>>(postDetailDto);
		}
	}
}