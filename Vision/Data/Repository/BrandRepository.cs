using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Vision.Interfaces;
using Vision.Models;

namespace Vision.Data.Repository {
	public class BrandRepository : IBrand {

		private readonly DbContext _context;

		public BrandRepository(DbContext context) {
			_context = context;
		}

		public async Task<IList<Brand>> allBrands() => await _context.Brands.ToListAsync();

		public async Task createBrand(string name, string disc, List<Guid> clothes) {
			var brand = new Brand {
				name = name,
				disc = disc,
				clothesID = clothes
			};
			_context.Brands.Add(brand);

			await _context.SaveChangesAsync();
		}

		public async Task delete(Guid id) {
			var brand = _context.Brands.FirstOrDefault(x => x.id == id);
			_context.Brands.Remove(brand);

			await _context.SaveChangesAsync();
		}
	}
}
