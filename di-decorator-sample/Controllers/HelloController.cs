using DIDecoratorSample.Services;
using Microsoft.AspNetCore.Mvc;

namespace DIDecoratorSample.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class HelloController : ControllerBase
	{
		private readonly IHelloService _helloService;

		public HelloController(IHelloService helloService)
		{
			_helloService = helloService;
		}

		[HttpGet]
		public string SayIt(string name)
		{
			return _helloService.SayHello(name);
		}
	}
}
