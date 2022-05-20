using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vision.Models;

namespace Vision.Interfaces {
	public interface IAuthor {
		Task<IList<Author>> allAuthors();

		Task createAuthor(string name);

		Task delete(Guid id);
	}
}
