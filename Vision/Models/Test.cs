using System;
using System.ComponentModel.DataAnnotations;

namespace Vision.Models {
	public class Test {

		[Key]
		public Guid id { get; set; }
		public string name { get; set; }
		public double price { get; set; }

		public Test() {

		}
	}
}
