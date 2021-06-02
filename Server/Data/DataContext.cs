using BlazingShop.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingShop.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext( DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                  new Category { Id = 1, name = "Books", Url = "books", Icon = "book" },
                new Category { Id = 2, name = "Electronics", Url = "electronics", Icon = "camera-slr" },
                new Category { Id = 3, name = "Video games", Url = "video-games", Icon = "aperture" }

                );
            modelBuilder.Entity<Product>().HasData(
                 new Product
                 {
                     Id = 1,
                     CategoryId = 1,
                     Title = "The hitchhiker",
                     Description = "The hitchhiker's guide to the galaxy",
                     Image = "https://en.wikipedia.org/wiki/File:H2G2_UK_front_cover.jpg#/media/File:H2G2_UK_front_cover.jpg",
                     Price = 9.99m,
                     OriginalPrice = 19.99m,

                 },
         new Product
         {
             Id = 2,
             CategoryId = 2,
             Title = "The Half-life2",
             Description = "HALF=LIFE the best game",
             Image = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-life_2_cover.jgp",
             Price = 9.99m,
             OriginalPrice = 19.99m,

         },
          new Product
          {
              Id = 3,
              CategoryId = 3,
              Title = "The Half-life3",
              Description = "HALF=LIFE the best game",
              Image = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-life_2_cover.jgp",
              Price = 9.99m,
              OriginalPrice = 19.99m,

          },
           new Product
           {
               Id = 4,
               CategoryId = 1,
               Title = "The Half-life4",
               Description = "HALF=LIFE the best game",
               Image = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-life_2_cover.jgp",
               Price = 9.99m,
               OriginalPrice = 19.99m,

           },
            new Product
            {
                Id = 5,
                CategoryId = 2,
                Title = "The Half-life5",
                Description = "HALF=LIFE the best game",
                Image = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-life_2_cover.jgp",
                Price = 9.99m,
                OriginalPrice = 19.99m,

            },
             new Product
             {
                 Id = 6,
                 CategoryId = 3,
                 Title = "The Half-life6",
                 Description = "HALF=LIFE the best game",
                 Image = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-life_2_cover.jgp",
                 Price = 9.99m,
                 OriginalPrice = 19.99m,

             }
                );
        }
    }
}
