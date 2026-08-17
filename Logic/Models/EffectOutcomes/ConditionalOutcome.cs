namespace Logic.Models.EffectOutcomes;

public class ConditionalOutcome : EffectOutcome {
    public CardAction[] Conditions { get; set; }
    public CardAction[] Results { get; set; }
}