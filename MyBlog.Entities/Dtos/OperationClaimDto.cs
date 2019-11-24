using MyBlog.Core.Entities.Abstract;

namespace MyBlog.Core.Entities.Dtos
{
	public class OperationClaimDto : IDto
	{
		public int Id { get; set; }
		public string Name { get; set; }
	}
}
