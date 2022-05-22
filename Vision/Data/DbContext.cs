using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Vision.Models;

namespace Vision {

    public class DbContext : Microsoft.EntityFrameworkCore.DbContext {
		public DbSet<Product> Products { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Article> Articles { get; set; }
		public DbSet<Author> Authors { get; set; }
		//public DbSet<User> Users { get; set; }
		//public DbSet<Cart> Carts { get; set; }
		//public DbSet<Favorite> Favorites { get; set; }
		//public DbSet<Shop> Shops { get; set; }
		public DbSet<Brand> Brands { get; set; }
		public DbSet<Image> Images { get; set; }
		//public DbSet<Test> Articles { get; set; }

		public string DbPath { get; }

		public DbContext() {
			// var folder = Environment.SpecialFolder.LocalApplicationData;
			// var path = Environment.GetFolderPath(folder);
			//DbPath = System.IO.Path.Join(path, "Vision.db");
			DbPath = System.IO.Path.Join("Data", "Vision.db");
		}

		// The following configures EF to create a Sqlite database file in the
		// special "local" folder for your platform.

		protected override void OnConfiguring(DbContextOptionsBuilder options)
			=> options.UseSqlite($"Data Source={DbPath}");

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        //    optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=AppDbContext;Trusted_Connection=True;MultipleActiveResultSets=true;");
        //}

        //protected override void OnModelCreating(ModelBuilder modelBuilder) {
        //    modelBuilder.Entity<Category>().HasNoKey();
        //}
    }
}