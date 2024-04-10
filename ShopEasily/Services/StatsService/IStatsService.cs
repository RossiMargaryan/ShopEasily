using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopEasily.Client.Services.StatsService
{
    // This interface defines the contract for a service responsible for managing statistics data.
    interface IStatsService
    {
        // Retrieves the number of visits from the server.
        Task GetVisits();

        // Increments the visit count on the server.
        Task IncrementVisits();
    }
}