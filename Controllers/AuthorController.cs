using BLogProject.Data;
using BLogProject.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BLogProject.Controllers
{		[Authorize]
		[ApiController]
		[Route("api/[controller]")]
		
		public class AuthorController : ControllerBase
		{
			[HttpGet]

			public ActionResult Get()
			{
				return Ok("My name is rex");
			}

		}
}
