using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Vision.Interfaces;
using Vision.Models;

namespace Vision.Data.Repository {
	public class AuthorRepository : IAuthor {

		private readonly DbContext _context;

		public AuthorRepository(DbContext context) {
			_context = context;
		}

		public async Task<IList<Author>> allAuthors() => await _context.Authors.ToListAsync();

		public async Task createAuthor(string name, List<Guid> articles, double rating) {
			var author = new Author {
				name = name,
				articles = articles,
				rating = rating
			};
			_context.Authors.Add(author);

			await _context.SaveChangesAsync();
		}

		public async Task delete(Guid id) {
			var author = _context.Authors.FirstOrDefault(x => x.id == id);
			_context.Authors.Remove(author);

			await _context.SaveChangesAsync();
		}
	}
}
