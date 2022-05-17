using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Vision.Storage {
	public class Category {

		[Key]
		public Guid id;
		public string name;
		public string sizeTable;

		public List<Product> catClothes;
	}
}
