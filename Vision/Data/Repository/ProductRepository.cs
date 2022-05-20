using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Vision.Interfaces;
using Vision.Models;

namespace Vision.Data.Repository {
	public class ProductRepository : IProduct {

		private readonly DbContext _context;

		public ProductRepository(DbContext context) {
			_context = context;
		}

		public async Task<IList<Product>> allProducts() => await _context.Products.ToListAsync();

		public async Task createProduct(string name, double price, string link, string img, Guid categoryID, Guid brandID) {
			var product = new Product {
				name = name,
				price = price,
				link = link,
				img = img,
				rating = 0,
				categoryID = categoryID,
				brandID = brandID
			};
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
