using ShopEasily.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ShopEasily.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _http;

        public event Action OnChange;

        // Collection to store retrieved products.

        public List<Product> Products { get; set; } = new List<Product>();

        public ProductService(HttpClient http)
        {
            _http = http;
        }


        // Retrieves products from the server and populates the Products collection.
        public async Task LoadProducts(string categoryUrl = null)
        {
            // Sends a request to the server to retrieve products.
            // Populates the Products collection with the retrieved products.
            // Triggers the OnChange event to notify subscribers that the product list has changed.

            if (categoryUrl == null)
            {
                Products = await _http.GetFromJsonAsync<List<Product>>("api/Product");
            }
            else
            {
                Products = await _http.GetFromJsonAsync<List<Product>>($"api/Product/Category/{categoryUrl}");
            }
            OnChange.Invoke();
        }

        // Retrieves a specific product by its ID from the server.

        public async Task<Product> GetProduct(int id)
        {
            // Sends a request to the server to retrieve a product by its ID.
            // Returns the retrieved product. 

            return await _http.GetFromJsonAsync<Product>($"api/Product/{id}");
        }

        // Searches for products based on the provided search text.
        public async Task<List<Product>> SearchProducts(string searchText)
        {
            // Sends a request to the server to search for products.
            // Returns the list of products matching the search criteria.

            return await _http.GetFromJsonAsync<List<Product>>($"api/Product/Search/{searchText}");
        }
    }
}

