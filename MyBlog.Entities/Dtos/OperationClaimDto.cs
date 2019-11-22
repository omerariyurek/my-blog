using System;
using System.Collections.Generic;
using System.Text;
using MyBlog.Core.Entities.Abstract;

namespace MyBlog.Entities.Dtos
{
	public class OperationClaimDto : IDto
	{
		public int Id { get; set; }
		public string Name { get; set; }
	}
}
