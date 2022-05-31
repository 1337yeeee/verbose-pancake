using System;
using System.Linq;
using Vision.Models;

namespace Vision.Data {
	public class InitialData {
		private readonly DbContext _context;

		public InitialData(DbContext context) {
			_context = context;

			//Author._default = _context.Au
		}
	}
}
