using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vision.Models;

namespace Vision.Interfaces {
	public interface IProduct {

		Task<IList<Product>> allProducts();

		Task createProduct(string name, double price, string link, Image img,
							Guid categoryID, Guid brandID);

		Task delete(Guid id);

	}
}
