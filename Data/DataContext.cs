using BLogProject.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BLogProject.Data
{
	public class DataContext : IdentityDbContext
	{
		public DataContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
		{ 
		
		}

		DbSet<Blog> Blogs {  get; set; }
		DbSet<MainComment> Comments { get; set; }
		DbSet<SubComment> Subcomments { get; set; }
		DbSet<Like> Likes { get; set; }



	}
}
