using System.Collections.Generic;

namespace Model.DAO
{
	public partial class User
	{
		public User()
		{
			Addresses = new HashSet<Address>();
		}

		public int Id { get; set; }

		public string FirstName { get; set; }

		public string LastName { get; set; }

		public int? Age { get; set; }

		public string Email { get; set; }

		public string Password { get; set; }

		public virtual ICollection<Address> Addresses { get; set; }
	}
}
