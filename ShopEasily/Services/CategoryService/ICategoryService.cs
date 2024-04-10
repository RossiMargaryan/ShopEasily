using ShopEasily.Shared;
using ShopEasily.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopEasily.Client.Services.CategoryService
{
    // This interface defines the contract for a service responsible for managing category data.
    interface ICategoryService
    {
        // Collection to store retrieved categories.
        List<Category> Categories { get; set; }

        // Retrieves categories from the server.
        Task LoadCategories();
    }
}
