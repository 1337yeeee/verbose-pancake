using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Vision.Storage {
	public class Brand {

		[Key]
		public Guid id { get; set; }

		public string name;

		public List<Product> clothes { get; set; }

		public Brand() {
		}
	}
}
