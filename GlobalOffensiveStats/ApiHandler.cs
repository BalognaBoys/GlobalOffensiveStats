using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GlobalOffensiveStats.Constants;
using System.Net;
using System.Runtime.Serialization.Json;

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
                String url = generateUrlForUserStatsForGame(steamId64);
                HttpWebResponse apiResponse = MakeRequest(url);
                ProcessResponse(apiResponse);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.Read();
            }

            return UserStatsFromApi;
        }

        private void ProcessResponse(HttpWebResponse apiResponse)
        {
            throw new NotImplementedException();
        }

        private HttpWebResponse MakeRequest(string url)
        {
            try
            {
                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                        throw new Exception(
                            String.Format(
                                "Server error (HTTP {0}: {1}).",
                                response.StatusCode,
                                response.StatusDescription)
                            );
                    return response;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        private String generateUrlForUserStatsForGame(int steamId64)
        {
            return "http://api.steampowered.com/ISteamUserStats/GetUserStatsForGame/v0002/"
            + "?appid=" + appId
            + "&key=" + apiKey
            + "&steamid=" + steamId64;
        }

        public String getSteamId64FromCommunityId(String steamCommunityId)
        {
            try
            {
                String url = generateUrlForNameConversion(steamCommunityId);
                HttpWebResponse apiResponse = MakeRequest(url);
                ProcessResponse(apiResponse);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.Read();
            }
        }

        private String generateUrlForNameConversion(string steamCommunityId)
        {
            return "http://api.steampowered.com/ISteamUser/ResolveVanityURL/v0001/"
            + "?key=" + apiKey
            + "&vanityurl=" + steamCommunityId;
        }
    }
}
