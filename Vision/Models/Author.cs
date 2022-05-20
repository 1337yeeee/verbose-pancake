using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Vision.Models {
	public class Author {

		[Key]
		public Guid id { get; set; }

		public string name { get; set; }
		public List<Guid> articles { get; set; }
		public double rating { get; set; }

		public Author() {
		}
	}
}
