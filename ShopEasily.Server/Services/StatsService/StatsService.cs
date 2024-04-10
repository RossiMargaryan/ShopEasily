using ShopEasily.Server.Data;
using ShopEasily.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopEasily.Server.Services.StatsService
{
    public class StatsService : IStatsService
    {
        private readonly DataContext _context;

        public StatsService(DataContext context)
        {
            _context = context;
        }

        // Retrieves the number of visits asynchronously
        public async Task<int> GetVisits()
        {
            // Retrieve the stats from the database

            var stats = await _context.Stats.FirstOrDefaultAsync();

            // Return the number of visits
            // If stats is null, return 0

            if (stats == null)
            {
                return 0;
            }
            return stats.Visits;
        }

        // Increments the number of visits asynchronously
        public async Task IncrementVisits()
        {
            // Retrieve the stats from the database

            var stats = await _context.Stats.FirstOrDefaultAsync();

            // If stats is null, create a new stats record with visits as 1

            if (stats == null)
            {

                _context.Stats.Add(new Stats { Visits = 1, LastVisit = DateTime.Now });
            }
            else
            {
                stats.Visits++;
                stats.LastVisit = DateTime.Now;
            }

            // Save changes to the database

            await _context.SaveChangesAsync();
        }
    }
}

