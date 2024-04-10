using ShopEasily.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopEasily.Server.Services.CategoryService
{
    public interface ICategoryService
    {

        // Retrieves all categories asynchronously
        Task<List<Category>> GetCategories();

        // Retrieves a category by its URL asynchronously
        Task<Category> GetCategoryByUrl(string categoryUrl);
    }
}

