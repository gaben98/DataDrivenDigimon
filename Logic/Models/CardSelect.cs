namespace Logic.Models; 

public class CardSelect {
    public CardQuery[] Query { get; set; } = [];
    public int? MinCards { get; set; }
    public int? MaxCards { get; set; }
}