using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Vision.Interfaces;
using Vision.Models;

namespace Vision.Data.Repository {
	public struct CategoryRepository : ICategory {

		public readonly DbContext _context;

		public CategoryRepository(DbContext context) {
			_context = context;
		}

		public async Task<IList<Category>> allCategories() => await _context.Categories.ToListAsync();

		public async Task createCategory(string name, string sizeTable, List<Guid> clothes) {
			var category = new Category {
				name = name,
				sizeTable = sizeTable,
				clothes = clothes
			};
			_context.Categories.Add(category);

			await _context.SaveChangesAsync();
		}

		public async Task delete(Guid id) {
			var category = _context.Categories.FirstOrDefault(x => x.id == id);
			_context.Categories.Remove(category);

			await _context.SaveChangesAsync();
		}
	}
}
