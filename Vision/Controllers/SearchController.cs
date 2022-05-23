using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Vision.Controllers {
	public class SearchController : Controller {

		private readonly ILogger<HomeController> _logger;
		private readonly DbContext _context;

		public SearchController(ILogger<HomeController> logger, DbContext context) {
			_logger = logger;
			_context = context;
		}

	}
}
