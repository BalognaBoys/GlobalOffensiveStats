using System;

public class CsgoStatsModel
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



    public CsgoStatsModel()
    {
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

    public void setTotalMoneyEarned(int totalDamageDone)
    {
        this.totalDamageDone = totalDamageDone;
    }

    public int getTotalDamageDone()
    {
        return totalDamageDone;
    }
}