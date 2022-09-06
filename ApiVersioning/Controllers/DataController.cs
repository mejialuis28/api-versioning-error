using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ApiVersioning.Controllers
{
	[ApiVersion("1.0")]
	[ApiController]
	[Route("[controller]")]
	[Route("/v{version:apiVersion}/[controller]")]
	public class DataController : ControllerBase
	{
		[HttpGet()]
		public async Task<IActionResult> Get()
		{
			// Some async call
			return Ok("OK from V1");
		}
	}
}
