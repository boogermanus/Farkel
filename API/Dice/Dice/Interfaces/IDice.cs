namespace Dice.Interfaces;

public interface IDice<T> where T : notnull
{
    IEnumerable<IDie<T>> Dice { get; }   
}
