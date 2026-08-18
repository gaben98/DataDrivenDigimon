using System.Text.Json.Serialization;
using Logic.Models.PlayConditions;

namespace Logic.Models;

public class Card
{
    public string Id { get; set; } = "";
    public Subcard[] Subcards { get; set; } = [];
}

[JsonDerivedType(typeof(DigimonCard), "digimon")]
[JsonDerivedType(typeof(OptionCard), "option")]
[JsonDerivedType(typeof(TamerCard), "tamer")]
public class Subcard
{
    public string Name { get; set; } = "";
    public string[] Colors { get; set; } = [];
    //public int PlayCost { get; set; }
    /// <summary>
    /// Can be played if any play condition is satisfied.
    /// </summary>
    public PlayCondition[] PlayConditions { get; set; } = [];
    public string[] Traits { get; set; } = [];
    public Effect[] Effects { get; set; } = [];
    public Dictionary<string, int> Stats { get; set; } = [];
}

public class DigimonCard : Subcard
{
    // public int DPower { get; set; }
    // public int Level { get; set; }
    public Digivolution[] Digivolutions { get; set; } = [];
}

public class OptionCard : Subcard
{

}

public class TamerCard : Subcard
{
    
}

[JsonDerivedType(typeof(CantPlayToField), "cant-play-to-field")]
[JsonDerivedType(typeof(CardExists), "card-exists")]
[JsonDerivedType(typeof(DeployLocations), "deploy-locations")]
[JsonDerivedType(typeof(MultipleConditionsSatisfied), "multiple-conditions-satisfied")]
[JsonDerivedType(typeof(MustDigivolve), "must-digivolve")]
public abstract class PlayCondition { }
