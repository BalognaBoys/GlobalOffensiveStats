using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GlobalOffensiveStats.Constants;
using System.Net;
using System.Runtime.Serialization.Formatters;

namespace GlobalOffensiveStats
{
    class ApiHandler
    {
        public String apiKey;
        public String appId;

        public ApiHandler()
        {
            apiKey = ApiKey.API_KEY;
            appId = Steam.CSGO_APP_ID;
        }

        public Dictionary<String, int> getUserStatsForGame(int steamId64)
        {
            Dictionary<String, int> UserStatsFromApi = new Dictionary<string,int>();

            try
            {
                string url = generateUrlForUserStatsForGame(steamId64);
                Response apiResponse = MakeRequest(url);
                ProcessResponse(locationsResponse);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.Read();
            }

            return UserStatsFromApi;
        }

        private String generateUrlForUserStatsForGame(int steamId64)
        {
            return "http://api.steampowered.com/ISteamUserStats/GetUserStatsForGame/v0002/"
            + "?appid=" + appId
            + "&key=" + apiKey
            + "&steamid=" + steamId64;
        }

        //http://api.steampowered.com/ISteamUser/ResolveVanityURL/v0001/?key=31747EB051E9A5134F22D17E48AC8CB7&vanityurl=deathbed210
        public int getSteamId64FromCommunityId(String steamCommunityId)
        {

        }
    }
}
