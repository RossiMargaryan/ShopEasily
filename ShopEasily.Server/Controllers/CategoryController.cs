using ShopEasily.Server.Services.CategoryService;
using ShopEasily.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopEasily.Server.Controllers
{
    // Represents a controller for handling operations related to product categories.
    // For example, fetching all categories or retrieving a category by its URL.
    // [HttpGet] action: Retrieves a list of categories.
    // [HttpGet("{categoryUrl}")] action: Retrieves a category by its URL.

    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        // Service for interacting with category data.
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }


        // Retrieves a list of all categories.
        [HttpGet]
        public async Task<ActionResult<List<Category>>> GetCategories()
        {
            return Ok(await _categoryService.GetCategories());
        }
    }
}



