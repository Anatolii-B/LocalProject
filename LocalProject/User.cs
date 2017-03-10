namespace LocalProject
{
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;

	[Table("acc.User")]
	public partial class User
	{
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
		public User()
		{
			Addresses = new HashSet<Address>();
		}

		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		public int Id { get; set; }

		[Required]
		[StringLength(64)]
		public string FirstName { get; set; }

		[Required]
		[StringLength(64)]
		public string LastName { get; set; }

		public int? Age { get; set; }

		[Required]
		[StringLength(128)]
		public string Email { get; set; }

		[Required]
		[StringLength(128)]
		public string Password { get; set; }

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
		public virtual ICollection<Address> Addresses { get; set; }
	}
}
