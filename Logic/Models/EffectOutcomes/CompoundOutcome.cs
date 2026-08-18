namespace Logic.Models.EffectOutcomes;

public class CompoundOutcome : EffectOutcome
{
    public CardQuery[] Targets { get; set; } = [];
    public int? MinSelectedTargets { get; set; }
    public int? MaxSelectedTargets { get; set; }
    public EffectOutcome[] Outcomes { get; set; } = [];
}