using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GlobalOffensiveStats.Models;

namespace GlobalOffensiveStats.Models
{
    class User
    {
        private string steamId;
        private int steamId64;
        private List<CsgoStats> allStatsList;   //TODO: find a beter name for allStatsList

        public void updateStats()
        {
            allStatsList.Add(getStatsFromApi());
        }

        private CsgoStats getStatsFromApi()
        {
            CsgoStats newStats;
            Dictionary<String, int> UserStatsFromApi;

            UserStatsFromApi = this.makeApiCall();
            newStats = new CsgoStats(UserStatsFromApi);
            return newStats;
        }

        public Dictionary<String, int> makeApiCall()
        {
            ApiHandler apiHandler = new ApiHandler();

            Dictionary<String, int> UserStatsFromApi = apiHandler.getUserStatsForGame(steamId64);
            return UserStatsFromApi;
        }
    }
}
