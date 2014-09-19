using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GlobalOffensiveStats.Models;
using GlobalOffensiveStats;

namespace GlobalOffensiveStats.Models
{
    class User
    {
        private string steamCommunityId;
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

            UserStatsFromApi = this.makeApiCallForStats();
            newStats = new CsgoStats(UserStatsFromApi);
            return newStats;
        }

        public Dictionary<String, int> makeApiCallForStats()
        {
            ApiHandler apiHandler = new ApiHandler();

            Dictionary<String, int> UserStatsFromApi = apiHandler.getUserStatsForGame(steamId64);
            return UserStatsFromApi;
        }

        public void setSteamId(String steamCommunityId)
        {
            this.steamCommunityId = steamCommunityId;
        }

        public void setSteamId64()
        {
            ApiHandler apiHandler = new ApiHandler();
            steamId64 = apiHandler.getSteamId64FromCommunityId(steamCommunityId);
        }

    }
}
