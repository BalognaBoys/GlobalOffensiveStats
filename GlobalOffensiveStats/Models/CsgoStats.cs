using System;
using System.Collections.Generic;
using GlobalOffensiveStats.Constants;

namespace GlobalOffensiveStats.Models
{
    public class CsgoStats
    {

        private int totalKills;
        private int totalDeaths;
        private int totalWins;
        private int totalDamageDone;
        private int totalMoneyEarned;
        private int totalHeadshotKills;
        private int totalShotsFired;
        private int totalShotsHit;
        private int totalRoundsPlayed;
        private int totalMvps;
        private float allTimeAccuracy;



        public CsgoStats(Dictionary<String, int> UserStatsFromApi)
        {
            totalKills = UserStatsFromApi[GetUserStatsForGameConstants.TOTAL_KILLS];
            totalDeaths = UserStatsFromApi[GetUserStatsForGameConstants.TOTAL_DEATHS];
            totalWins = UserStatsFromApi[GetUserStatsForGameConstants.TOTAL_WINS];
            totalDamageDone = UserStatsFromApi[GetUserStatsForGameConstants.TOTAL_DAMAGE_DONE];
            totalMoneyEarned = UserStatsFromApi[GetUserStatsForGameConstants.TOTAL_MONEY_EARNED];
            totalHeadshotKills = UserStatsFromApi[GetUserStatsForGameConstants.TOTAL_HEADSHOT_KILLS];
            totalShotsFired = UserStatsFromApi[GetUserStatsForGameConstants.TOTAL_SHOTS_FIRED];
            totalShotsHit = UserStatsFromApi[GetUserStatsForGameConstants.TOTAL_SHOTS_HIT];
            totalRoundsPlayed = UserStatsFromApi[GetUserStatsForGameConstants.TOTAL_ROUNDS_PLAYED];
            totalMvps = UserStatsFromApi[GetUserStatsForGameConstants.TOTAL_MVPS];
            allTimeAccuracy = totalShotsHit / totalShotsFired;
        }

        public void setTotalKills(int totalKills)
        {
            this.totalKills = totalKills;
        }

        public int getTotalKills()
        {
            return totalKills;
        }

        public void setTotalDeaths(int totalDeaths)
        {
            this.totalDeaths = totalDeaths;
        }

        public int getTotalDeaths()
        {
            return totalDeaths;
        }

        public void setTotalWins(int totalWins)
        {
            this.totalWins = totalWins;
        }

        public int getTotalWins()
        {
            return totalWins;
        }

        public void setTotalDamageDone(int totalDamageDone)
        {
            this.totalDamageDone = totalDamageDone;
        }

        public int getTotalDamageDone()
        {
            return totalDamageDone;
        }

        public void setTotalMoneyEarned(int totalMoneyEarned)
        {
            this.totalMoneyEarned = totalMoneyEarned;
        }

        public int getTotalMoneyEarned()
        {
            return totalMoneyEarned;
        }

        public void setTotalHeadshotKills(int totalHeadshotKills)
        {
            this.totalHeadshotKills = totalHeadshotKills;
        }

        public int getTotalHeadshotKills()
        {
            return totalHeadshotKills;
        }

        public void setTotalShotsFired(int totalShotsFired)
        {
            this.totalShotsFired = totalShotsFired;
        }

        public int getTotalShotsFired()
        {
            return totalShotsFired;
        }

        public void setTotalShotsHit(int totalShotsHit)
        {
            this.totalShotsHit = totalShotsHit;
        }

        public int getTotalShotsHit()
        {
            return totalShotsHit;
        }

        public void setTotalRoundsPlayed(int totalRoundsPlayed)
        {
            this.totalRoundsPlayed = totalRoundsPlayed;
        }

        public int getTotalRoundsPlayed()
        {
            return totalRoundsPlayed;
        }

        public void setTotalMvps(int totalMvps)
        {
            this.totalMvps = totalMvps;
        }

        public int getTotalMvps()
        {
            return totalMvps;
        }

        public void setAllTimeAccuracy(float allTimeAccuracy)
        {
            this.allTimeAccuracy = allTimeAccuracy;
        }

        public float getAllTimeAccuracy()
        {
            if (allTimeAccuracy == 0)
            {
                allTimeAccuracy = totalShotsHit / totalShotsFired;
            }

            return allTimeAccuracy;
        }
    }
}