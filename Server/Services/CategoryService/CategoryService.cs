﻿using BlazingShop.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingShop.Server.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        public List<Category> Categories { get; set; } = new List<Category>
            {
                new Category {Id = 1, name = "Books", Url = "books", Icon = "book"},
                new Category {Id = 2, name = "Electronics", Url = "electronics", Icon = "camera-slr"},
                new Category {Id = 3, name = "Video games", Url = "video-games", Icon = "aperture"}
            };
        public async Task<List<Category>> GetCategories()
        {
            return Categories;
        }

        public async Task<Category> GetCategoryByUrl(string categoryUrl)
        {
            return Categories.FirstOrDefault(c => c.Url.ToLower().Equals(categoryUrl.ToLower()));
        }
    }
}
