using ShopEasily.Shared;
using ShopEasily.Client.Services.CategoryService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ShopEasily.Client.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly HttpClient _http;

        // Collection to store retrieved categories.
        public List<Category> Categories { get; set; } = new List<Category>();

        public CategoryService(HttpClient http)
        {
            _http = http;
        }

        // Retrieves categories from the server and populates the Categories collection.
        public async Task LoadCategories()
        {
            // Sends a request to the server to retrieve categories.
            // Populates the Categories collection with the retrieved categories.

            Categories = await _http.GetFromJsonAsync<List<Category>>("api/Category");
        }
    }
}
