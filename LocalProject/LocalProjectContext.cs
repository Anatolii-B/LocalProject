namespace LocalProject
{
	using System;
	using System.Data.Entity;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Linq;

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
}
