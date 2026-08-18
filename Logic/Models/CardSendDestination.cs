namespace Logic.Models;

public abstract class CardSendDestination { }

public class ToLocation : CardSendDestination
{
    public Location Location { get; set; } = Location.Field;
}

public class UnderneathCard : CardSendDestination
{
    /// <summary>
    /// Query that specifies what card this card can be placed underneath
    /// </summary>
    public CardQuery TargetQuery { get; set; } = new();
    /// <summary>
    /// Whether this card placed face-up or face-down underneath the target card
    /// </summary>
    public bool Visibility { get; set; }
}
