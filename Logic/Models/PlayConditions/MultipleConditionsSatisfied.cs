namespace Logic.Models.PlayConditions;

public class MultipleConditionsSatisfied : PlayCondition
{
    public PlayCondition[] Conditions { get; set; }
}