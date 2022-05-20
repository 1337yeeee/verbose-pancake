using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vision.Storage;

namespace Vision.Interfaces {
	public interface IProducts {

		Task<IList<Product>> allProducts();

		Task createProduct(string name, double price);

		Task delete(Guid id);

	}
}
