using System;
using Vision.Storage;

namespace Vision {
	public class DbSead {

		static void Create(AppDbContext context) {
			Brand balenca = new Brand {
				name = "Balenciaga",
				id = Guid.NewGuid(),
			};
			Category sneaker = new Category {
				name = "sneaker",
				id = Guid.NewGuid(),
			};
			Brand brand2 = new Brand {
				name = "Danila",
				id = Guid.NewGuid(),
			};
			Category category2 = new Category {
				name = "tshirt",
				id = Guid.NewGuid(),
			};

			Product item1 = new Product {
				id = Guid.NewGuid(),
				img = "img/pic1",
				isFav = true,
				price = 100500,
				rating = 3.5,
				link = "www.www",
				name = "Paris Sneaker",
				brand = balenca,
				brandID = balenca.id,
				category = sneaker,
				categoryID = sneaker.id,
			};
	}
}
