﻿using Microsoft.AspNetCore.Identity;

namespace BLogProject.Model
{
	public class ApplicationUser : IdentityUser
	{
		public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
