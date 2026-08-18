namespace Logic.Models.PlayConditions;

public class CardExists : PlayCondition
{
    public CardQuery[] Targets { get; set; } = [];
}
