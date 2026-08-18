using System.Text.Json.Serialization;
using Logic.Models.EffectConditions;
using Logic.Models.EffectOutcomes;

namespace Logic.Models;

public class Effect
{
    public EffectCondition[] Conditions { get; set; } = [];
    public string[] Triggers { get; set; } = [];
    public EffectOutcome[] Outcomes { get; set; } = [];
}

[JsonDerivedType(typeof(Act), "act")]
[JsonDerivedType(typeof(AssignKeywords), "assign-keywords")]
[JsonDerivedType(typeof(CompoundOutcome), "compound-outcome")]
[JsonDerivedType(typeof(ConditionalOutcome), "conditional-outcome")]
[JsonDerivedType(typeof(DrawNCards), "draw-n-cards")]
public abstract class EffectOutcome
{
    public bool Mandatory { get; set; }
}

[JsonDerivedType(typeof(CardExists), "card-exists")]
[JsonDerivedType(typeof(EffectIsInherited), "effect-is-inherited")]
[JsonDerivedType(typeof(OncePerTurn), "once-per-turn")]
public abstract class EffectCondition { }