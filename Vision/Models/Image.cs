using System;
using System.ComponentModel.DataAnnotations;

namespace Vision.Models {
	public class Image {

		[Key]
		public Guid id { get; set; }
		public string path { get; set; }

	}
}
