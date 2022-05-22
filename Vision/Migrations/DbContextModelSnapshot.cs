﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Vision;

namespace Vision.Migrations
{
    [DbContext(typeof(DbContext))]
    partial class DbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.16");

            modelBuilder.Entity("Vision.Models.Article", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("authorID")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("date")
                        .HasColumnType("TEXT");

                    b.Property<string>("header")
                        .HasColumnType("TEXT");

                    b.Property<string>("name")
                        .HasColumnType("TEXT");

                    b.Property<string>("text")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.HasIndex("authorID");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("Vision.Models.Author", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("name")
                        .HasColumnType("TEXT");

                    b.Property<double>("rating")
                        .HasColumnType("REAL");

                    b.HasKey("id");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("Vision.Models.Brand", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("disc")
                        .HasColumnType("TEXT");

                    b.Property<string>("name")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("Vision.Models.Category", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("name")
                        .HasColumnType("TEXT");

                    b.Property<string>("sizeTable")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Vision.Models.Image", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("Articleid")
                        .HasColumnType("TEXT");

                    b.Property<string>("path")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.HasIndex("Articleid");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("Vision.Models.Product", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("Articleid")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("brandID")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("categoryID")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("imgid")
                        .HasColumnType("TEXT");

                    b.Property<string>("link")
                        .HasColumnType("TEXT");

                    b.Property<string>("name")
                        .HasColumnType("TEXT");

                    b.Property<double>("price")
                        .HasColumnType("REAL");

                    b.Property<double>("rating")
                        .HasColumnType("REAL");

                    b.HasKey("id");

                    b.HasIndex("Articleid");

                    b.HasIndex("brandID");

                    b.HasIndex("categoryID");

                    b.HasIndex("imgid");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Vision.Models.Article", b =>
                {
                    b.HasOne("Vision.Models.Author", "author")
                        .WithMany("articles")
                        .HasForeignKey("authorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("author");
                });

            modelBuilder.Entity("Vision.Models.Image", b =>
                {
                    b.HasOne("Vision.Models.Article", null)
                        .WithMany("img")
                        .HasForeignKey("Articleid");
                });

            modelBuilder.Entity("Vision.Models.Product", b =>
                {
                    b.HasOne("Vision.Models.Article", null)
                        .WithMany("productList")
                        .HasForeignKey("Articleid");

                    b.HasOne("Vision.Models.Brand", "brand")
                        .WithMany("clothesID")
                        .HasForeignKey("brandID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Vision.Models.Category", "category")
                        .WithMany("clothes")
                        .HasForeignKey("categoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Vision.Models.Image", "img")
                        .WithMany()
                        .HasForeignKey("imgid");

                    b.Navigation("brand");

                    b.Navigation("category");

                    b.Navigation("img");
                });

            modelBuilder.Entity("Vision.Models.Article", b =>
                {
                    b.Navigation("img");

                    b.Navigation("productList");
                });

            modelBuilder.Entity("Vision.Models.Author", b =>
                {
                    b.Navigation("articles");
                });

            modelBuilder.Entity("Vision.Models.Brand", b =>
                {
                    b.Navigation("clothesID");
                });

            modelBuilder.Entity("Vision.Models.Category", b =>
                {
                    b.Navigation("clothes");
                });
#pragma warning restore 612, 618
        }
    }
}
