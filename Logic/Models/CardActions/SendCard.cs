namespace Logic.Models.CardActions;

public class SendCard : CardAction
{
    public CardSendDestination Destination { get; set; } = new ToLocation();
}