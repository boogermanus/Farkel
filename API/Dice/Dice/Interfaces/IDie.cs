namespace Dice.Interfaces;

public interface IDie<T> where T : notnull
{
    IEnumerable<T> Sides { get; }
}