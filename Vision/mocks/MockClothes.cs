using System;
using System.Collections.Generic;
using System.Linq;
using Vision.Interfaces;
using Vision.Storage;

namespace Vision.mocks
{
	public class MockClothes : IAllClothes
	{
		public MockClothes()
		{
		}

		private readonly ICategory _category = new MockCategory();

		public IEnumerable<Clothes> Goods { get {
				return new List<Clothes> {
					new Clothes {category = _category.AllCategories.First(), price = 1500, link = "www.www",
						img = "1asd.img", isFav = true, rating = 0, name = "hoodie" },

					new Clothes {category = _category.AllCategories.First(), price = 5000, link = "www.www",
						img = "2asd.img", isFav = true, rating = 0, name = "T-shirt"},

					new Clothes {category = _category.AllCategories.Last(), price = 2300, link = "www.www",
						img = "3asd.img", isFav = true, rating = 0, name = "Shorts"},

					new Clothes {category = _category.AllCategories.Last(), price = 4240, link = "www.www",
						img = "4asd.img", isFav = false, rating = 0, name = "Jeans" },

					new Clothes {category = _category.AllCategories.First(), price = 43000, link = "www.www",
						img = "5asd.img", isFav = false, rating = 0, name = "Jacket" },

					new Clothes {category = _category.AllCategories.Last(), price = 6000, link = "www.www",
						img = "6asd.img", isFav = false, rating = 0, name = "Pants" },
				};
			}
		}
		public IEnumerable<Clothes> getFavClothes { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		public Clothes GetClothes(int clothesID)
		{
			throw new NotImplementedException();
		}
	}
}
