using System;
using System.Collections.Generic;

namespace Vision.Storage
{
	public class Cart
	{
		public int id { get; set; }
		public List<Clothes> goods;
		public int userID { get; set; }

		public Cart()
		{
		}
	}
}
