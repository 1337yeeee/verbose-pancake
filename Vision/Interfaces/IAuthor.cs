using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vision.Models;

namespace Vision.Interfaces {
	public interface IAuthor {
		Task<IList<Author>> allAuthors();

		Task createAuthor(string name, List<Guid> articles, double rating);

		Task delete(Guid id);
	}
}
