using Microsoft.EntityFrameworkCore;
using My_MdAjans_Blog.Entities;

namespace My_MdAjans_Blog.Context
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions options) : base(options)//veritabanı bağlantısı için
		{
		}
		public DbSet<User> Users { get; set; }
		public DbSet<Note> Notes { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Comment> Comments { get; set; }

	}
}
