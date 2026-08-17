namespace Logic.Models.EffectConditions;

public class CardExists : EffectCondition
{
    public CardQuery[] Targets { get; set; }
}