using ATM.Project.Attributes;

namespace ATM.Project.Models;

public class Card
{
    public int Id { get; set; }

    [CardNumber]
    public string CardNumber {  get; set; }

    public string CardName { get; set; }

    [Password]
    public string? Password {  get; set; }

    public decimal Balance { get; set; }
}
