using ShopEasily.Server.Data;
using ShopEasily.Shared;
using Microsoft.EntityFrameworkCore;
using ShopEasily.Server.Services.CategoryService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopEasily.Server.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly DataContext _context;

        public CategoryService(DataContext context)
        {
            _context = context;
        }

        // Retrieves all categories from the database
        public async Task<List<Category>> GetCategories()
        {
            return await _context.Categories.ToListAsync();
        }


        // Retrieves a category by its URL from the database
        public async Task<Category> GetCategoryByUrl(string categoryUrl)
        {
            return await _context.Categories.
                FirstOrDefaultAsync(c => c.Url.ToLower().Equals(categoryUrl.ToLower()));
        }
    }
}

