namespace Logic.Models.EffectOutcomes;

public class AssignKeywords : EffectOutcome
{
    public CardSelect Target { get; set; } = new();
    public string[] Keywords { get; set; } = [];
}