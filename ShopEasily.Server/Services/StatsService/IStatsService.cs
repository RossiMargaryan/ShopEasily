using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopEasily.Server.Services.StatsService
{
    public interface IStatsService
    {
        // Retrieves the number of visits asynchronously
        Task<int> GetVisits();

        // Increments the number of visits asynchronously
        Task IncrementVisits();
    }
}

