using Microsoft.EntityFrameworkCore;
using project.Model;
using project.Enums;

namespace project.Data {
	
	public class AppDbContext : DbContext {
		
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{
			
		}
		
		public DbSet<Book> Books { get; set; }
		
		/// EF core reads the values of an enum like 0, 1, 2, etc
		/// with the help of this method, we convert TaskStatusEnum values to string instead of 0, 1, etc
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Book>()
				.Property(t => t.Language)
				.HasConversion<string>();
		}
	}
	
}
