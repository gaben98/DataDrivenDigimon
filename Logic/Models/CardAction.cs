using System.Text.Json.Serialization;
using Logic.Models.CardActions;

namespace Logic.Models;

[JsonDerivedType(typeof(DeDigivolve), "de-digivolve")]
[JsonDerivedType(typeof(SendCard), "send-card")]
public class CardAction
{
    public CardSelect Target { get; set; } = new();
}