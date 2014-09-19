// Type created for JSON at <<root>>
[System.Runtime.Serialization.DataContractAttribute()]
public partial class GlobalOffensiveStatsContract
{

    [System.Runtime.Serialization.DataMemberAttribute()]
    public Playerstats playerstats;
}

// Type created for JSON at <<root>> --> playerstats
[System.Runtime.Serialization.DataContractAttribute(Name = "playerstats")]
public partial class Playerstats
{

    [System.Runtime.Serialization.DataMemberAttribute()]
    public string steamID;

    [System.Runtime.Serialization.DataMemberAttribute()]
    public string gameName;

    [System.Runtime.Serialization.DataMemberAttribute()]
    public Stats[] stats;

    [System.Runtime.Serialization.DataMemberAttribute()]
    public Achievements[] achievements;
}

// Type created for JSON at <<root>> --> playerstats --> stats
[System.Runtime.Serialization.DataContractAttribute(Name = "stats")]
public partial class Stats
{

    [System.Runtime.Serialization.DataMemberAttribute()]
    public string name;

    [System.Runtime.Serialization.DataMemberAttribute()]
    public int value;
}

// Type created for JSON at <<root>> --> playerstats --> achievements
[System.Runtime.Serialization.DataContractAttribute(Name = "achievements")]
public partial class Achievements
{

    [System.Runtime.Serialization.DataMemberAttribute()]
    public string name;

    [System.Runtime.Serialization.DataMemberAttribute()]
    public int achieved;
}