using System;
using System.Collections.Generic;
using Vision.Storage;

namespace Vision.Interfaces
{
	public interface IAllClothes
	{
		IEnumerable<Product> Goods { get; }

		IEnumerable<Product> getFavClothes { get; set; }

		Product GetClothes(int clothesID);
	}
}
