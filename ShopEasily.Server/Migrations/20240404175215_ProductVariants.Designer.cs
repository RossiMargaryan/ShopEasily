﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShopEasily.Server.Data;

namespace ShopEasily.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240404175215_ProductVariants")]
    partial class ProductVariants
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ShopEasily.Shared.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Icon = "book",
                            Name = "Books",
                            Url = "books"
                        },
                        new
                        {
                            Id = 2,
                            Icon = "camera-slr",
                            Name = "Electronics",
                            Url = "electronics"
                        },
                        new
                        {
                            Id = 3,
                            Icon = "aperture",
                            Name = "Video Games",
                            Url = "video-games"
                        });
                });

            modelBuilder.Entity("ShopEasily.Shared.Edition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Editions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Default"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Paperback"
                        },
                        new
                        {
                            Id = 3,
                            Name = "E-Book"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Audiobook"
                        },
                        new
                        {
                            Id = 5,
                            Name = "PC"
                        },
                        new
                        {
                            Id = 6,
                            Name = "PlayStation"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Xbox"
                        });
                });

            modelBuilder.Entity("ShopEasily.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPublic")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Views")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            DateCreated = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "The Hitchhiker's Guide to the Galaxy (sometimes referred to as HG2G, HHGTTG, H2G2, or tHGttG) is a comedy science fiction series created by Douglas Adams.",
                            Image = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "The Hitchhiker's Guide to the Galaxy",
                            Views = 0
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            DateCreated = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Ready Player One is a 2011 science fiction novel, and the debut novel of American author Ernest Cline. The story, set in a dystopia in 2045, follows protagonist Wade Watts on his search for an Easter egg in a worldwide virtual reality game, the discovery of which would lead him to inherit the game creator's fortune.",
                            Image = "https://upload.wikimedia.org/wikipedia/en/a/a4/Ready_Player_One_cover.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "Ready Player One",
                            Views = 0
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            DateCreated = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Nineteen Eighty-Four: A Novel, often published as 1984, is a dystopian social science fiction novel by English novelist George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime.",
                            Image = "https://upload.wikimedia.org/wikipedia/commons/c/c3/1984first.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "Nineteen Eighty-Four",
                            Views = 0
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            DateCreated = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "The Pentax Spotmatic refers to a family of 35mm single-lens reflex cameras manufactured by the Asahi Optical Co. Ltd., later known as Pentax Corporation, between 1964 and 1976.",
                            Image = "https://upload.wikimedia.org/wikipedia/commons/e/e9/Honeywell-Pentax-Spotmatic.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "Pentax Spotmatic",
                            Views = 0
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            DateCreated = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "The Xbox is a home video game console and the first installment in the Xbox series of video game consoles manufactured by Microsoft.",
                            Image = "https://upload.wikimedia.org/wikipedia/commons/4/43/Xbox-console.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "Xbox",
                            Views = 0
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            DateCreated = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "The Super Nintendo Entertainment System (SNES), also known as the Super NES or Super Nintendo, is a 16-bit home video game console developed by Nintendo that was released in 1990 in Japan and South Korea.",
                            Image = "https://upload.wikimedia.org/wikipedia/commons/e/ee/Nintendo-Super-Famicom-Set-FL.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "Super Nintendo Entertainment System",
                            Views = 0
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 3,
                            DateCreated = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Half-Life 2 is a 2004 first-person shooter game developed and published by Valve. Like the original Half-Life, it combines shooting, puzzles, and storytelling, and adds features such as vehicles and physics-based gameplay.",
                            Image = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "Half-Life 2",
                            Views = 0
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 3,
                            DateCreated = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Diablo II is an action role-playing hack-and-slash computer video game developed by Blizzard North and published by Blizzard Entertainment in 2000 for Microsoft Windows, Classic Mac OS, and macOS.",
                            Image = "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "Diablo II",
                            Views = 0
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 3,
                            DateCreated = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Day of the Tentacle, also known as Maniac Mansion II: Day of the Tentacle, is a 1993 graphic adventure game developed and published by LucasArts. It is the sequel to the 1987 game Maniac Mansion.",
                            Image = "https://upload.wikimedia.org/wikipedia/en/7/79/Day_of_the_Tentacle_artwork.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "Day of the Tentacle",
                            Views = 0
                        });
                });

            modelBuilder.Entity("ShopEasily.Shared.ProductVariant", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("EditionId")
                        .HasColumnType("int");

                    b.Property<decimal>("OriginalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductId", "EditionId");

                    b.HasIndex("EditionId");

                    b.ToTable("ProductVariant");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            EditionId = 2,
                            OriginalPrice = 19.99m,
                            Price = 9.99m
                        },
                        new
                        {
                            ProductId = 1,
                            EditionId = 3,
                            OriginalPrice = 0m,
                            Price = 7.99m
                        },
                        new
                        {
                            ProductId = 1,
                            EditionId = 4,
                            OriginalPrice = 29.99m,
                            Price = 19.99m
                        },
                        new
                        {
                            ProductId = 2,
                            EditionId = 2,
                            OriginalPrice = 14.99m,
                            Price = 7.99m
                        },
                        new
                        {
                            ProductId = 3,
                            EditionId = 2,
                            OriginalPrice = 0m,
                            Price = 6.99m
                        },
                        new
                        {
                            ProductId = 4,
                            EditionId = 1,
                            OriginalPrice = 249.00m,
                            Price = 166.66m
                        },
                        new
                        {
                            ProductId = 5,
                            EditionId = 1,
                            OriginalPrice = 299m,
                            Price = 159.99m
                        },
                        new
                        {
                            ProductId = 6,
                            EditionId = 1,
                            OriginalPrice = 400m,
                            Price = 73.74m
                        },
                        new
                        {
                            ProductId = 7,
                            EditionId = 5,
                            OriginalPrice = 29.99m,
                            Price = 19.99m
                        },
                        new
                        {
                            ProductId = 7,
                            EditionId = 6,
                            OriginalPrice = 0m,
                            Price = 69.99m
                        },
                        new
                        {
                            ProductId = 7,
                            EditionId = 7,
                            OriginalPrice = 59.99m,
                            Price = 49.99m
                        },
                        new
                        {
                            ProductId = 8,
                            EditionId = 5,
                            OriginalPrice = 24.99m,
                            Price = 9.99m
                        },
                        new
                        {
                            ProductId = 9,
                            EditionId = 5,
                            OriginalPrice = 0m,
                            Price = 14.99m
                        });
                });

            modelBuilder.Entity("ShopEasily.Shared.Stats", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime?>("LastVisit")
                        .HasColumnType("datetime2");

                    b.Property<int>("Visits")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Stats");
                });

            modelBuilder.Entity("ShopEasily.Shared.Product", b =>
                {
                    b.HasOne("ShopEasily.Shared.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ShopEasily.Shared.ProductVariant", b =>
                {
                    b.HasOne("ShopEasily.Shared.Edition", "Edition")
                        .WithMany()
                        .HasForeignKey("EditionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShopEasily.Shared.Product", "Product")
                        .WithMany("Variants")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Edition");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ShopEasily.Shared.Product", b =>
                {
                    b.Navigation("Variants");
                });
#pragma warning restore 612, 618
        }
    }
}
