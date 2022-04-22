using System;
namespace Vision.Storage
{
	public class Clothes
	{
		public int id { get; set; }
		public Category category { get; set; }
		public string name { get; set; }
		public int brandID { get; set; }
		public float price { get; set; }
		public string link { get; set; }
		public string img { get; set; }
		public bool isFav { get; set; }
		public float rating { get; set; }

		public Clothes()
		{
		}
	}
}
