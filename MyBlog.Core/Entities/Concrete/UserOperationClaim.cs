using System;
using System.Collections.Generic;
using System.Text;
using MyBlog.Core.Entities.Abstract;

namespace MyBlog.Core.Entities.Concrete
{
	public class UserOperationClaim : IEntity
	{
		public int Id { get; set; }
		public int UserId { get; set; }
		public int OperationClaimId { get; set; }
		public User User { get; set; }
		public OperationClaim OperationClaim { get; set; }
	}
}
