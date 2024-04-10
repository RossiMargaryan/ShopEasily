using ShopEasily.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopEasily.Server.Services.ProductService
{
    public interface IProductService
    {
        // Retrieves all products asynchronously
        Task<List<Product>> GetAllProducts();

        // Retrieves a product by its ID asynchronously
        Task<List<Product>> GetProductsByCategory(string categoryUrl);

        // Retrieves products by category URL asynchronously
        Task<Product> GetProduct(int id);

        // Searches products by search text asynchronously
        Task<List<Product>> SearchProducts(string searchText);
    }
}


