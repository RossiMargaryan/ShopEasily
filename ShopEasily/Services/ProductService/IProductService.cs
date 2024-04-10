using ShopEasily.Shared;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopEasily.Client.Services.ProductService
{
    // This interface defines the contract for a service responsible for managing product data.
    public interface IProductService
    {
        event Action OnChange;

        // Collection to store retrieved products.
        List<Product> Products { get; set; }

        // Retrieves products from the server.
        Task LoadProducts(string categoryUrl = null);

        // Retrieves a specific product by its ID from the server.
        Task<Product> GetProduct(int id);

        // Searches for products based on the provided search text.
        Task<List<Product>> SearchProducts(string searchText);
    }
}

