using System;
using System.ComponentModel.DataAnnotations;

namespace Vision.Storage
{
	public class Product
	{
		[Key]
		public Guid id { get; set; }
		//public Category category { get; set; }
		public string name { get; set; }
		public double price { get; set; }
		public string link { get; set; }
		public string img { get; set; }
		public bool isFav { get; set; }
		public double rating { get; set; }

		public Category category { get; set; }
		public Guid categoryID { get; set; }

		public Brand brand { get; set; }
		public Guid brandID { get; set; }

		public Product()
		{
		}
	}
}
