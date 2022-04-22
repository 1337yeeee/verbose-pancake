using System;
using System.Collections.Generic;
using Vision.Storage;

namespace Vision.Interfaces
{
	public interface IAllClothes
	{
		IEnumerable<Clothes> Goods { get; }

		IEnumerable<Clothes> getFavClothes { get; set; }

		Clothes GetClothes(int clothesID);
	}
}
