using System;
using System.Collections.Generic;
using Vision.Storage;

namespace Vision {
	public class DbSead {

		public static void Create(DbContext context) {
			Brand balenca = new Brand {
				name = "Balenciaga",
				id = Guid.NewGuid(),
			};
			Category sneaker = new Category {
				name = "sneaker",
				id = Guid.NewGuid(),
			};
			Brand danila = new Brand {
				name = "Danila",
				id = Guid.NewGuid(),
			};
			Category tshirt = new Category {
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

			Product item2 = new Product {
				id = Guid.NewGuid(),
				brand = danila,
				brandID = danila.id,
				category = tshirt,
				categoryID = tshirt.id,
				name = "Krasivaya",
				price = 50000,
				img = "img/krasivaya",
				isFav = true,
				link = "danila.com",
				rating = 4.6,
			};
			balenca.clothes = new List<Product>();
			balenca.clothes.Add(item1);
			sneaker.clothes = new List<Product>();
			sneaker.clothes.Add(item1);

			danila.clothes = new List<Product>();
			danila.clothes.Add(item2);
			tshirt.clothes = new List<Product>();
			tshirt.clothes.Add(item2);

			context.Products.Add(item1);
			context.Products.Add(item2);

			context.SaveChanges();
		}
	}
}
