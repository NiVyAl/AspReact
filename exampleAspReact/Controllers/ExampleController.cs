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
			Console.WriteLine($"{data.name}, {data.surname}, {data.years}, {data.isSubscribe}");
			AddUser(data);
			return true;
		}

		public async void AddUser(User data)
		{
			_context.User.Add(data);
			int result = await _context.SaveChangesAsync();
			Console.WriteLine(result);
		}
	}
}

