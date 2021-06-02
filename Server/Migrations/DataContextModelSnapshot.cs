﻿// <auto-generated />
using System;
using BlazingShop.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlazingShop.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BlazingShop.Shared.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Icon = "book",
                            Url = "books",
                            name = "Books"
                        },
                        new
                        {
                            Id = 2,
                            Icon = "camera-slr",
                            Url = "electronics",
                            name = "Electronics"
                        },
                        new
                        {
                            Id = 3,
                            Icon = "aperture",
                            Url = "video-games",
                            name = "Video games"
                        });
                });

            modelBuilder.Entity("BlazingShop.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPublic")
                        .HasColumnType("bit");

                    b.Property<decimal>("OriginalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            DateCreated = new DateTime(2021, 6, 2, 17, 47, 59, 323, DateTimeKind.Local).AddTicks(6995),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "The hitchhiker's guide to the galaxy",
                            Image = "https://en.wikipedia.org/wiki/File:H2G2_UK_front_cover.jpg#/media/File:H2G2_UK_front_cover.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 19.99m,
                            Price = 9.99m,
                            Title = "The hitchhiker"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            DateCreated = new DateTime(2021, 6, 2, 17, 47, 59, 325, DateTimeKind.Local).AddTicks(3594),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "HALF=LIFE the best game",
                            Image = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-life_2_cover.jgp",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 19.99m,
                            Price = 9.99m,
                            Title = "The Half-life2"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            DateCreated = new DateTime(2021, 6, 2, 17, 47, 59, 325, DateTimeKind.Local).AddTicks(3620),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "HALF=LIFE the best game",
                            Image = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-life_2_cover.jgp",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 19.99m,
                            Price = 9.99m,
                            Title = "The Half-life3"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            DateCreated = new DateTime(2021, 6, 2, 17, 47, 59, 325, DateTimeKind.Local).AddTicks(3624),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "HALF=LIFE the best game",
                            Image = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-life_2_cover.jgp",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 19.99m,
                            Price = 9.99m,
                            Title = "The Half-life4"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            DateCreated = new DateTime(2021, 6, 2, 17, 47, 59, 325, DateTimeKind.Local).AddTicks(3627),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "HALF=LIFE the best game",
                            Image = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-life_2_cover.jgp",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 19.99m,
                            Price = 9.99m,
                            Title = "The Half-life5"
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 3,
                            DateCreated = new DateTime(2021, 6, 2, 17, 47, 59, 325, DateTimeKind.Local).AddTicks(3629),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "HALF=LIFE the best game",
                            Image = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-life_2_cover.jgp",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 19.99m,
                            Price = 9.99m,
                            Title = "The Half-life6"
                        });
                });

            modelBuilder.Entity("BlazingShop.Shared.Product", b =>
                {
                    b.HasOne("BlazingShop.Shared.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("BlazingShop.Shared.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
