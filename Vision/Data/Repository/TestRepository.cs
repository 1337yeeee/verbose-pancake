using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Vision.Interfaces;
using Vision.Models;
using Vision.Storage;

namespace Vision.Data.Repository {
	public class TestRepository : ITest {

		private readonly DbContext _context;

		public TestRepository(DbContext context) {
			_context = context;
		}

		public async Task<IList<Test>> allTests() => await _context.Tests.ToListAsync();

		public async Task createTest(string name, double price) {
			var test = new Test { name = name, price = price };
			_context.Tests.Add(test);
			await _context.SaveChangesAsync();
		}

		public async Task delete(Guid id) {
			var test = _context.Tests.FirstOrDefault(x => x.id == id);
			_context.Tests.Remove(test);
			await _context.SaveChangesAsync();
		}
	}
}
