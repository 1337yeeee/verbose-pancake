using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Vision.Storage;

namespace Vision {

    public class AppDbContext : DbContext {
        public DbSet<Product> Clothes { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Favorite> Favorites { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Brand> brands { get; set; } 

        public string DbPath { get; }

        public AppDbContext() {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "Vision.db");
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }
}