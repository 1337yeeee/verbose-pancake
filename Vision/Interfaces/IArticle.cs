using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vision.Models;

namespace Vision.Interfaces {
	public interface IArticle {
		Task<IList<Article>> allArticles();

		Task createArticle(string name, string header, Guid authorID, DateTime date,
						string text, List<string> img, List<Guid> productList);

		Task delete(Guid id);
	}
}
