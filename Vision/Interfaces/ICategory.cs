using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vision.Models;

namespace Vision.Interfaces {
	public interface ICategory {

		Task<IList<Category>> allCategories();

		Task createCategory(string name, string sizeTable);

		Task delete(Guid id);
	}
}
