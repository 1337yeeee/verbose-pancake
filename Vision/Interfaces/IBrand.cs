using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vision.Models;

namespace Vision.Interfaces {
	public interface IBrand {

		Task<IList<Brand>> allBrands();

		Task createBrand(string name, string disc);

		Task delete(Guid id);
	}
}
