namespace Logic.Models;

public class Effect
{
    public EffectCondition[] Conditions { get; set; }
    public string[] Triggers { get; set; }
    public EffectOutcome[] Outcomes { get; set; }
}

public abstract class EffectOutcome
{
    public bool Mandatory { get; set; }
}

public abstract class EffectCondition { }