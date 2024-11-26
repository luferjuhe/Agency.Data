using System;
namespace Agency.Data.Entities
{
	public class User
	{
		public int UserId { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public DateTime CreationDate { get; set; }
		public DateTime? InactiveDate { get; set; }
		public int CreationUserId { get; set; }
	}
}

