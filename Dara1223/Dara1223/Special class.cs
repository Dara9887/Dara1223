public interface IDisplayable
{
    void Display();
}

public abstract class BaseCard : IDisplayable
{
    public int Value { get; protected set; }
    public int Suit { get; protected set; }

    public BaseCard(int value, int suit)
    {
        Value = value;
        Suit = suit;
    }

    public abstract int GetNumber();

    public abstract string GetOperator();

    public void Display()
    {
        Console.WriteLine($"Value: {Value}, Suit: {Suit}");
    }
}

public class SpecialCard : BaseCard
{
    public SpecialCard(int value, int suit) : base(value, suit)
    {
    }

    public override int GetNumber()
    {
        return Value * 2; // Example of modifying behavior in the derived class
    }

    public override string GetOperator()
    {
        return Suit switch
        {
            1 => "^", // Exponentiation
            2 => "%", // Modulus
            _ => GetOperator() // Fall back to base class implementation for other suits
        };
    }
}