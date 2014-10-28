using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace KendoUiWithApiControllers.Models
{
	public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
	{
		public ApplicationDbContext()
			: base("DefaultConnection", false)
		{
		}

		public DbSet<Order> Orders { get; set; }

		public static ApplicationDbContext Create()
		{
			return new ApplicationDbContext();
		}
	}
}