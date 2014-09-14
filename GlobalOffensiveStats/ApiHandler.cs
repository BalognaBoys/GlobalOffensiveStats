using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GlobalOffensiveStats.Constants;

namespace GlobalOffensiveStats
{
    class ApiHandler
    {
        public String apiKey;

        public ApiHandler()
        {
            apiKey = ApiKey.API_KEY;
        }

        public Dictionary<String, int> getUserStatsForGame(int steamId64)
        {
            Dictionary<String, int> UserStatsFromApi = new Dictionary<string,int>();

            return UserStatsFromApi;
        }
    }
}
