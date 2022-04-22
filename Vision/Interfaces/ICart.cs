using System;
using System.Collections.Generic;
using Vision.Storage;

namespace Vision.Interfaces
{
	public interface ICart
	{
		IEnumerable<Clothes> GetClothes { get; }
	}
}
