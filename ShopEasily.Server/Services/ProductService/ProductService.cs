using ShopEasily.Server.Data;
using ShopEasily.Server.Services.CategoryService;
using ShopEasily.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopEasily.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly ICategoryService _categoryService;
        private readonly DataContext _context;

        public ProductService(ICategoryService categoryService, DataContext context)
        {
            _categoryService = categoryService;
            _context = context;
        }

        // Retrieves all products asynchronously
        public async Task<List<Product>> GetAllProducts()
        {
            // Retrieve all products from the database
            // Include variants to load related entities

            return await _context.Products.Include(p => p.Variants).ToListAsync();
        }

        // Retrieves a product by its ID asynchronously
        public async Task<Product> GetProduct(int id)
        {
            // Retrieve a product by its ID from the database
            // Include variants and editions to load related entities

            Product product = await _context.Products
                .Include(p => p.Variants)
                .ThenInclude(v => v.Edition)
                .FirstOrDefaultAsync(p => p.Id == id);

            product.Views++;

            await _context.SaveChangesAsync();

            return product;
        }

        // Retrieves products by category URL asynchronously
        public async Task<List<Product>> GetProductsByCategory(string categoryUrl)
        {
            Category category = await _categoryService.GetCategoryByUrl(categoryUrl);
            return await _context.Products.Include(p => p.Variants).Where(p => p.CategoryId == category.Id).ToListAsync();
        }

        // Searches products by search text asynchronously
        public async Task<List<Product>> SearchProducts(string searchText)
        {
            return await _context.Products
                .Where(p => p.Title.Contains(searchText) || p.Description.Contains(searchText))
                .ToListAsync();
        }
    }
}



