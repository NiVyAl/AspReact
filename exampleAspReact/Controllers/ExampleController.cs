//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;

//// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

//namespace exampleAspReact.Controllers
//{
//	public class ExampleController : Controller
//	{
//		// GET: /<controller>/
//		public IActionResult Index()
//		{
//			return View();
//		}
//	}
//}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using exampleAspReact.Models;
using exampleAspReact.Data;

namespace exampleAspReact.Controllers
{
	[ApiController]
	[Route("[controller]")] // после включения фронт падает с 404
	[Produces("application/json")]
	public class ExampleController : ControllerBase
    {

		private readonly ILogger<ExampleController> _logger;
		private exampleAspReact.Data.MyDbContext _context;
		//private readonly MyDbContext _myDbContext = new MyDbContext();

		public ExampleController(ILogger<ExampleController> logger, exampleAspReact.Data.MyDbContext context)
		{
			_logger = logger;
			_context = context;
			Console.WriteLine("Logger: ");
			Console.WriteLine(_logger);
			Console.WriteLine();
		}

		//[HttpGet]
		//public string Get(int id)
		//{
		//	Console.WriteLine("Get");
		//	Console.WriteLine(id);
		//	return $"{id} message from the server!";
		//}

		[HttpGet]
		public string Index()
        {
            return "This is my default action...";
        }

		[HttpGet("{welcome}")]
		public string Welcome(int id, string name)
        {
            return $"This is the Welcome action method, id: {id}, name: {name}";
        }

		[HttpPost]
		public bool Form([FromBody] User data)
		{

			Console.WriteLine($"{data.ID}, {data.name}, {data.surname}, {data.years}, {data.isSubscribe}");
			_context.User.Add(data);
			_context.SaveChangesAsync();
			return true;
		}
	}
}

