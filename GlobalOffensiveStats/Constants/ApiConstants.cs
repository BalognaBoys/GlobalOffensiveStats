using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalOffensiveStats.Constants
{
    class GetUserStatsForGameConstants
    {
        public const String TOTAL_KILLS = "total_kills";
        public const String TOTAL_DEATHS = "total_deaths";
        public const String TOTAL_WINS = "total_wins";
        public const String TOTAL_DAMAGE_DONE = "total_damage_done";
        public const String TOTAL_MONEY_EARNED = "total_money_earned";
        public const String TOTAL_HEADSHOT_KILLS = "total_kills_headshot";
        public const String TOTAL_SHOTS_FIRED = "total_shots_fired";
        public const String TOTAL_SHOTS_HIT = "total_shots_hit";
        public const String TOTAL_ROUNDS_PLAYED = "total_rounds_played";
        public const String TOTAL_MVPS = "total_mvps";
    }

    class ApiKey
    {
        public const String API_KEY = "31747EB051E9A5134F22D17E48AC8CB7";
    }

    //Delete this later
    class StatNames
    {
        public List<String> statNames;

        public StatNames()
        {
             //For quick debug stuff
             statNames = new List<string>();

             statNames.Add(GetUserStatsForGameConstants.TOTAL_KILLS);
             statNames.Add(GetUserStatsForGameConstants.TOTAL_DEATHS);
             statNames.Add(GetUserStatsForGameConstants.TOTAL_WINS);
             statNames.Add(GetUserStatsForGameConstants.TOTAL_DAMAGE_DONE);
             statNames.Add(GetUserStatsForGameConstants.TOTAL_MONEY_EARNED);
             statNames.Add(GetUserStatsForGameConstants.TOTAL_HEADSHOT_KILLS);
             statNames.Add(GetUserStatsForGameConstants.TOTAL_SHOTS_FIRED);
             statNames.Add(GetUserStatsForGameConstants.TOTAL_SHOTS_HIT);
             statNames.Add(GetUserStatsForGameConstants.TOTAL_ROUNDS_PLAYED);
             statNames.Add(GetUserStatsForGameConstants.TOTAL_MVPS);
        }

    }
}
