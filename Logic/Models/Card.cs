namespace Logic.Models; 

public class Card
{
    public string Id { get; set; }
    public Subcard[] Subcards { get; set; }
}

public class Subcard
{
    public string Name { get; set; }
    public Color[] Colors { get; set; }
    //public int PlayCost { get; set; }
    /// <summary>
    /// Can be played if any play condition is satisfied.
    /// </summary>
    public PlayCondition[] PlayConditions { get; set; }
    public string[] Traits { get; set; }
    public Effect[] Effects { get; set; }
    public Dictionary<string, int> Stats { get; set; }
}

public class DigimonCard : Subcard
{
    // public int DPower { get; set; }
    // public int Level { get; set; }
    public Digivolution[] Digivolutions { get; set; }
}

public class OptionCard : Subcard
{

}

public class TamerCard : Subcard
{
    
}


public abstract class PlayCondition { }
