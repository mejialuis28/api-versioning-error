using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ApiVersioning.Controllers
{
	[ApiVersion("2.0")]
	[ApiController]
	[Route("/v{version:apiVersion}/Data")]
	public class Data2Controller : ControllerBase
	{

		[HttpGet()]
		public async Task<IActionResult> Get()
		{
			// Some async call
			return Ok("OK from V2");
		}
	}
}
