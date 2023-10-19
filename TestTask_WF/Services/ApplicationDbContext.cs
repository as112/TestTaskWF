using SQLite.CodeFirst;
using System;
using System.Data.Entity;
using TestTask_WF.Models;

namespace TestTask_WF.Services
{
	public class ApplicationDbContext : DbContext
	{

		public ApplicationDbContext() : base("name=SQLiteConnection") { }

		public DbSet<Users> Users { get; set; }
		public DbSet<Modes> Modes { get; set; }
		public DbSet<Steps> Steps { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Users>().ToTable("Users");
			modelBuilder.Entity<Modes>().ToTable("Modes");
			modelBuilder.Entity<Steps>().ToTable("Steps");

			var sqliteConnectionInitializer = new SqliteCreateDatabaseIfNotExists<ApplicationDbContext>(modelBuilder);
			Database.SetInitializer(sqliteConnectionInitializer);
		}

	}
}
