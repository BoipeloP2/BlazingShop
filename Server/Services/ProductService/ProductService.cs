using BlazingShop.Server.Services.CategoryService;
using BlazingShop.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingShop.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly ICategoryService _categroyService;

        public ProductService(ICategoryService categroyService)
        {
            _categroyService = categroyService;
        }
        public async Task<List<Product>> GetAllProducts()
        {
            return Products;
        }

        public async Task<Product> GetProduct(int id)
        {
            Product product = Products.FirstOrDefault(p => p.Id == id);
            return product;
        }

        public async Task<List<Product>> GetProductsByCategory(string categoryUrl)
        {
            Category category = await _categroyService.GetCategoryByUrl(categoryUrl);
            return Products.Where(p => p.CategoryId == category.Id).ToList();
        }

        public List<Product> Products { get; set; } = new List<Product>
            {

        new Product
        {
            Id = 1,
            CategoryId = 1,
            Title = "The hitchhiker",
            Description = "The hitchhiker's guide to the galaxy",
            Image = "https://en.wikipedia.org/wiki/File:H2G2_UK_front_cover.jpg#/media/File:H2G2_UK_front_cover.jpg",
            Price  = 9.99m,
            OriginalPrice = 19.99m,

        },
         new Product
        {
            Id = 2,
            CategoryId = 2,
            Title = "The Half-life2",
            Description = "HALF=LIFE the best game",
            Image = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-life_2_cover.jgp",
            Price  = 9.99m,
            OriginalPrice = 19.99m,

        },
          new Product
        {
            Id = 3,
            CategoryId = 3,
            Title = "The Half-life3",
            Description = "HALF=LIFE the best game",
            Image = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-life_2_cover.jgp",
            Price  = 9.99m,
            OriginalPrice = 19.99m,

        },
           new Product
        {
            Id = 4,
            CategoryId = 1,
            Title = "The Half-life4",
            Description = "HALF=LIFE the best game",
            Image = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-life_2_cover.jgp",
            Price  = 9.99m,
            OriginalPrice = 19.99m,

        },
            new Product
        {
            Id = 5,
            CategoryId = 2,
            Title = "The Half-life5",
            Description = "HALF=LIFE the best game",
            Image = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-life_2_cover.jgp",
            Price  = 9.99m,
            OriginalPrice = 19.99m,

        },
             new Product
        {
            Id = 6,
            CategoryId = 3,
            Title = "The Half-life6",
            Description = "HALF=LIFE the best game",
            Image = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-life_2_cover.jgp",
            Price  = 9.99m,
            OriginalPrice = 19.99m,

        }
            };
    }
}
