namespace LocalProject
{
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;

	[Table("acc.Address")]
	public partial class Address
	{
		public int Id { get; set; }

		[StringLength(512)]
		public string FullAddres { get; set; }

		public int UserId { get; set; }

		public virtual User User { get; set; }
	}
}
