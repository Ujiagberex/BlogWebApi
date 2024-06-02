using BLogProject.Model;
using Microsoft.AspNetCore.Identity;

namespace BLogProject.Services
{
	public class ConfigService
	{
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IServiceProvider serviceProvider)
		{
			// Other configurations

			SeedRoles(serviceProvider).Wait();
		}

		private async Task SeedRoles(IServiceProvider serviceProvider)
		{
			var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
			var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();

			string[] roleNames = { RoleNames.Author, RoleNames.Guest,};
			IdentityResult roleResult;

			foreach (var roleName in roleNames)
			{
				var roleExist = await roleManager.RoleExistsAsync(roleName);
				if (!roleExist)
				{
					roleResult = await roleManager.CreateAsync(new IdentityRole(roleName));
				}
			}

			// Create admin user
			var authorUser = new ApplicationUser
			{
				UserName = "author",
				Email = "author@example.com"
			};

			string authorPassword = "Author@123";
			var user = await userManager.FindByEmailAsync("author@example.com");

			if (user == null)
			{
				var createPowerUser = await userManager.CreateAsync(authorUser, authorPassword);
				if (createPowerUser.Succeeded)
				{
					await userManager.AddToRoleAsync(authorUser, RoleNames.Author);
				}
			}
		}
	}
}
