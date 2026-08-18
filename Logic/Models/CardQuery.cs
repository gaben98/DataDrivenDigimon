namespace Logic.Models;

public class CardQuery
{
    public string[] Traits { get; set; } = [];
    public CardType[] Types { get; set; } = [];
    public string[] IDs { get; set; } = [];
    public string[] Keywords { get; set; } = [];
    public int? MinLevel { get; set; }
    public int? MaxLevel { get; set; }
    public string[] Colors { get; set; } = [];
    public Location[] Locations { get; set; } = [];
    public bool? FaceDown { get; set; }
    public CardQuery? UnderneathQuery { get; set; }
    /// <summary>
    /// Whether this is a card in your play spaceand not the opponent's.
    /// True by default.
    /// </summary>
    public bool Yours { get; set; } = true;
    /// <summary>
    /// If true, the query selects the immediately relevant cards.
    /// If false, the query will not select the immediately relevant cards.
    /// Applies first before other queries
    /// </summary>
    public bool? ContextCards { get; set; }
}