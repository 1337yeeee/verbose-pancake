using System;
using System.ComponentModel.DataAnnotations;

namespace Vision.Models {
	public class Image {

		[Key]
		public Guid id { get; set; }
		public string ImageTitle { get; set; }
		public byte[] ImageData { get; set; }
	}
}
