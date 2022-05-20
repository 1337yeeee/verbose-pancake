using System;
using System.Collections.Generic;
using Vision.Storage;

namespace Vision.Models {
	public class ViewModel {

		public IEnumerable<Product> Products { get; set; }
		public IEnumerable<Category> Categories { get; set; }
		public IEnumerable<Brand> Brands { get; set; }
		public IEnumerable<Test> Tests { get; set; }


		public ViewModel() {
		}
	}
}
