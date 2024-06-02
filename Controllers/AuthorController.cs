using BLogProject.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BLogProject.Controllers
{
	public class AuthorController : ControllerBase
	{
		[Authorize(Roles = RoleNames.Author)]
		[ApiController]
		[Route("api/[controller]")]
		public class AdminController : ControllerBase
		{
			private readonly ILogger _logger;

		}

	}
}
