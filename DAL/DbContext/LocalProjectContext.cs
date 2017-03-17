using Model.DAO;
using System.Data.Entity;

public partial class LocalProjectContext : DbContext
{
	public LocalProjectContext()
		: base("name=LocalProjectContext")
	{
	}

	public virtual DbSet<Address> Addresses { get; set; }
	public virtual DbSet<User> Users { get; set; }

	protected override void OnModelCreating(DbModelBuilder modelBuilder)
	{
		modelBuilder.Entity<User>()
			.HasMany(e => e.Addresses)
			.WithRequired(e => e.User)
			.WillCascadeOnDelete(false);
	}
}
