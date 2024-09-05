using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Edu_Authen_Autho.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class EmployeeController : ControllerBase
	{
		[HttpGet("")]
		[Authorize]
		public async Task<ActionResult> GetData()
		{
			return Ok(new { EmployeeId = 1 });
		}
	}
}
