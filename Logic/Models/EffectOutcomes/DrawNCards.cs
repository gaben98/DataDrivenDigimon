namespace Logic.Models.EffectOutcomes;

public class DrawNCards : Act
{
    /// <summary>
    /// The number of cards to be drawn.
    /// </summary>
    public int N { get; set; }
    /// <summary>
    /// whether the drawn cards be visible to the player
    /// </summary>
    public bool Visible { get; set; }
    public Location Source { get; set; }
    /// <summary>
    /// Where to send the remaining unsent cards
    /// </summary>
    public CardSendDestination Remainder { get; set; }
}