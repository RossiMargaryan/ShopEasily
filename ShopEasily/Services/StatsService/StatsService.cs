using Blazored.LocalStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ShopEasily.Client.Services.StatsService
{
    public class StatsService : IStatsService
    {
        private readonly HttpClient _http;
        private readonly ILocalStorageService _localStorage;

        public StatsService(HttpClient http, ILocalStorageService localStorage)
        {
            _http = http;
            _localStorage = localStorage;
        }

        // Retrieves the number of visits from the server.
        public async Task GetVisits()
        {
            // Sends a request to the server to retrieve the number of visits.
            // Outputs the number of visits to the console.

            int visits = int.Parse(await _http.GetStringAsync("api/Stats"));
            Console.WriteLine($"Visits: {visits}");
        }


        // Increments the visit count on the server.
        public async Task IncrementVisits()
        {
            // Retrieves the last visit date from local storage.
            // Compares it with the current date to determine if a visit has already been counted for today.
            // If not, sends a request to the server to increment the visit count.

            DateTime? lastVisit = await _localStorage.GetItemAsync<DateTime?>("lastVisit");
            if (lastVisit == null || ((DateTime)lastVisit).Date != DateTime.Now.Date)
            {
                await _localStorage.SetItemAsync("lastVisit", DateTime.Now);
                await _http.PostAsync("api/Stats", null);
            }
        }
    }
}



