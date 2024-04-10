using ShopEasily.Server.Services.StatsService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopEasily.Server.Controllers
{
    // Represents a controller for handling statistics-related operations.
    // For example, retrieving the number of visits or incrementing visit count.
    // [HttpGet] action: Retrieves the total number of visits.
    // [HttpPost] action: Increments the visit count.

    [Route("api/[controller]")]
    [ApiController]
    public class StatsController : ControllerBase
    {
        // Service for interacting with statistics data.
        private readonly IStatsService _statsService;

        public StatsController(IStatsService statsService)
        {
            _statsService = statsService;
        }

        // Retrieves the total number of visits.
        [HttpGet]
        public async Task<ActionResult<int>> GetVisits()
        {
            return await _statsService.GetVisits();
        }

        // Increments the visit count.
        [HttpPost]
        public async Task IncrementVisits()
        {
            await _statsService.IncrementVisits();
        }
    }
}

