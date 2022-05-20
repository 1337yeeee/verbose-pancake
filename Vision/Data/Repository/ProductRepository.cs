using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Vision.Interfaces;
using Vision.Storage;

namespace Vision.Data.Repository {
	public class ProductRepository : IProducts {

		private readonly DbContext _context;

		public ProductRepository(DbContext context) {
			_context = context;
		}

		public async Task<IList<Product>> allProducts() => await _context.Products.ToListAsync();

		public async Task createProduct(string name, double price) {
			var product = new Product { name = name, price = price };
			_context.Products.Add(product);
			await _context.SaveChangesAsync();
		}

		public async Task delete(Guid id) {
			var product = _context.Products.FirstOrDefault(x => x.id == id);
			_context.Products.Remove(product);
			await _context.SaveChangesAsync();
		}
	}
}
