using ShopEasily.Server.Services.ProductService;
using ShopEasily.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopEasily.Server.Controllers
{
    // Represents a controller for handling operations related to products.
    // For example, fetching all products, retrieving a product by ID, or searching for products.
    // [HttpGet] actions: Retrieve all products, a product by ID, or products by category.
    // [HttpPost] action: Search for products by a given search text.

    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        // Service for interacting with product data.
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        // Retrieves a list of all products.
        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetAllProducts()
        {
            return Ok(await _productService.GetAllProducts());
        }

        // Retrieves products belonging to a specific category.
        [HttpGet("Category/{categoryUrl}")]
        public async Task<ActionResult<List<Product>>> GetProductsByCategory(string categoryUrl)
        {
            return Ok(await _productService.GetProductsByCategory(categoryUrl));
        }

        // Retrieves a product by its ID.
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            return Ok(await _productService.GetProduct(id));
        }

        // Searches for products using a provided search text.
        [HttpGet("Search/{searchText}")]
        public async Task<ActionResult<List<Product>>> SearchProducts(string searchText)
        {
            return Ok(await _productService.SearchProducts(searchText));
        }
    }
}
